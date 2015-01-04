open System
open System.IO
open System.Text
open System.Threading
open System.Runtime.InteropServices

open gpio
open spi
open lcdFont
open lcd

[<EntryPoint>]
let main argv =
  wipiInit.wiringPiSetup()

  let lcdConfig = {channel = spiChannel.channel0; pinRst = pinId.gpio24; pinDc = pinId.gpio23; pinLight = pinId.gpio18}

  lcdInit lcdConfig

  lcdCls lcdConfig
  lcdGoto lcdConfig 3uy 0uy
  lcdWriteString lcdConfig "PCD8544 Demo"

  for x in 1..60 do
    lcdGoto lcdConfig 0uy 1uy
    for i in 0..12 do
      lcdSend lcdConfig [| 0x11uy; 0x21uy; 0x41uy; 0x21uy; 0x11uy; |] High

    lcdGoto lcdConfig 6uy 2uy
    lcdWriteString lcdConfig (DateTime.Now.ToString( "yyyy/MMM/dd" ))
    lcdGoto lcdConfig 12uy 3uy
    lcdWriteString lcdConfig (DateTime.Now.ToString( "HH:mm:ss" ))

    lcdGoto lcdConfig 0uy 4uy
    for i in 0..12 do
      lcdSend lcdConfig [| 0x04uy; 0x02uy; 0x01uy; 0x02uy; 0x04uy; |] High

    Thread.Sleep( 1000 )

  lcdOff lcdConfig

  0 // return an integer exit code
