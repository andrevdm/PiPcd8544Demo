module lcd
open System
open System.Threading
open System.Runtime.InteropServices

open gpio
open spi
open lcdFont

type lcdConfig = { channel : spiChannel; pinRst : gpio.pinId; pinDc : gpio.pinId; pinLight : gpio.pinId  }

let lcdSend config (data: byte seq) dc =
  digitalWrite config.pinDc dc
  spiW config.channel (Seq.toArray data)

let lcdSendByte config data dc =
  digitalWrite config.pinDc dc
  spiWByte config.channel data

let bytesForLcdChar (c:char) =
  let idx = ((int c) - 0x20) * 5
  seq{ for i in 0..4 do yield lcdFont.font.[idx + i] }

let lcdWriteChar config (c : char) =
  lcdSend config (bytesForLcdChar c) High

let lcdWriteString config (s:string) =
  let bytes = s |> Seq.collect (fun c -> bytesForLcdChar c)
  lcdSend config bytes High

let lcdGoto config col row =
  lcdSend
    config
    [| (0x40uy + row)
       (0x80uy + col)
    |]
    Low

let lcdCls config =
  lcdGoto config 0uy 0uy
  lcdSend config (Array.zeroCreate 504) High
  lcdGoto config 0uy 0uy

let lcdInit config =
  spiSetup config.channel 4000000

  //output pins
  [config.pinRst; config.pinDc; config.pinLight]
  |> Seq.iter (fun pin -> pinMode pin Out)

  //Light off
  digitalWrite config.pinLight High

  //Reset LCD
  digitalWrite config.pinRst Low
  Thread.Sleep( 10 )
  digitalWrite config.pinRst High
  Thread.Sleep( 10 )

  //Light on
  digitalWrite config.pinLight Low

  lcdSend
    config
    [| (0x20uy + 0x01uy) //extended instructions on
       (0x80uy + 0x40uy) //set contrast 0 - 127
       (0x04uy + 0x02uy) //temp control
       (0x10uy + 0x03uy) //set bias system
       (0x20uy + 0x00uy) //return to basic instruction set, power on, set horizontal addressing
       (0x08uy + 0x04uy) //display control set to normal mode
    |]
    Low

let lcdOff config =
  //Light off
  digitalWrite config.pinLight High
