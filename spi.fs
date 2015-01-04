module spi
open System
open System.Text
open System.Runtime.InteropServices

module private imp =
  [<DllImport( "libwiringPiSPI.so", EntryPoint="wiringPiSPISetup", CallingConvention = CallingConvention.Cdecl, SetLastError=true )>]
  extern int wiringPiSPISetup( int channel, int speed );

  [<DllImport( "libwiringPiSPI.so", EntryPoint="wiringPiSPIDataRW", CallingConvention = CallingConvention.Cdecl, SetLastError=true )>]
  extern void wiringPiSPIDataRW( int channel, byte[] data, int len );

type spiChannel =
  | channel0 = 0
  | channel1 = 1

let spiSetup (channel:spiChannel) speed =
  let res = imp.wiringPiSPISetup( (int channel), speed )
  if res = -1 then
    failwith (sprintf "spi setup failed %d" res)

let spiWR channel (data : byte[]) =
  imp.wiringPiSPIDataRW( (int channel), data, data.Length )
  data

let spiW (channel:spiChannel) (data : byte[]) =
  spiWR channel data |> ignore

let spiWString (channel:spiChannel) (data : string) =
  spiWR channel (System.Text.Encoding.ASCII.GetBytes( data )) |> ignore

let spiWRByte (channel:spiChannel) (data : byte) =
  spiWR channel [| data |]

let spiWByte (channel:spiChannel) (data : byte) =
  spiWRByte channel data |>ignore
