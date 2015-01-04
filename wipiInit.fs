module wipiInit

open System
open System.Runtime.InteropServices

module private imp =
  [<DllImport( "libwiringPi.so", EntryPoint="wiringPiSetup", CallingConvention = CallingConvention.Cdecl, SetLastError=true )>]
  extern int WiringPiSetup();

let wiringPiSetup() =
  let res = imp.WiringPiSetup()
  if res <> 0 then
    failwith ("init failed with " + (res.ToString()))
