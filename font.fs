module lcdFont

let font = [|
  0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; // 20 space
  0x00uy; 0x00uy; 0x5fuy; 0x00uy; 0x00uy; // 21 !
  0x00uy; 0x07uy; 0x00uy; 0x07uy; 0x00uy; // 22 "
  0x14uy; 0x7fuy; 0x14uy; 0x7fuy; 0x14uy; // 23 #
  0x24uy; 0x2auy; 0x7fuy; 0x2auy; 0x12uy; // 24 $
  0x23uy; 0x13uy; 0x08uy; 0x64uy; 0x62uy; // 25 %
  0x36uy; 0x49uy; 0x55uy; 0x22uy; 0x50uy; // 26 &
  0x00uy; 0x05uy; 0x03uy; 0x00uy; 0x00uy; // 27 '
  0x00uy; 0x1cuy; 0x22uy; 0x41uy; 0x00uy; // 28 (
  0x00uy; 0x41uy; 0x22uy; 0x1cuy; 0x00uy; // 29 )
  0x14uy; 0x08uy; 0x3euy; 0x08uy; 0x14uy; // 2a *
  0x08uy; 0x08uy; 0x3euy; 0x08uy; 0x08uy; // 2b +
  0x00uy; 0x50uy; 0x30uy; 0x00uy; 0x00uy; // 2c uy
  0x08uy; 0x08uy; 0x08uy; 0x08uy; 0x08uy; // 2d -
  0x00uy; 0x60uy; 0x60uy; 0x00uy; 0x00uy; // 2e .
  0x20uy; 0x10uy; 0x08uy; 0x04uy; 0x02uy; // 2f /
  0x3euy; 0x51uy; 0x49uy; 0x45uy; 0x3euy; // 30 0
  0x00uy; 0x42uy; 0x7fuy; 0x40uy; 0x00uy; // 31 1
  0x42uy; 0x61uy; 0x51uy; 0x49uy; 0x46uy; // 32 2
  0x21uy; 0x41uy; 0x45uy; 0x4buy; 0x31uy; // 33 3
  0x18uy; 0x14uy; 0x12uy; 0x7fuy; 0x10uy; // 34 4
  0x27uy; 0x45uy; 0x45uy; 0x45uy; 0x39uy; // 35 5
  0x3cuy; 0x4auy; 0x49uy; 0x49uy; 0x30uy; // 36 6
  0x01uy; 0x71uy; 0x09uy; 0x05uy; 0x03uy; // 37 7
  0x36uy; 0x49uy; 0x49uy; 0x49uy; 0x36uy; // 38 8
  0x06uy; 0x49uy; 0x49uy; 0x29uy; 0x1euy; // 39 9
  0x00uy; 0x36uy; 0x36uy; 0x00uy; 0x00uy; // 3a :
  0x00uy; 0x56uy; 0x36uy; 0x00uy; 0x00uy; // 3b ;
  0x08uy; 0x14uy; 0x22uy; 0x41uy; 0x00uy; // 3c <
  0x14uy; 0x14uy; 0x14uy; 0x14uy; 0x14uy; // 3d =
  0x00uy; 0x41uy; 0x22uy; 0x14uy; 0x08uy; // 3e >
  0x02uy; 0x01uy; 0x51uy; 0x09uy; 0x06uy; // 3f ?
  0x32uy; 0x49uy; 0x79uy; 0x41uy; 0x3euy; // 40 @
  0x7euy; 0x11uy; 0x11uy; 0x11uy; 0x7euy; // 41 A
  0x7fuy; 0x49uy; 0x49uy; 0x49uy; 0x36uy; // 42 B
  0x3euy; 0x41uy; 0x41uy; 0x41uy; 0x22uy; // 43 C
  0x7fuy; 0x41uy; 0x41uy; 0x22uy; 0x1cuy; // 44 D
  0x7fuy; 0x49uy; 0x49uy; 0x49uy; 0x41uy; // 45 E
  0x7fuy; 0x09uy; 0x09uy; 0x09uy; 0x01uy; // 46 F
  0x3euy; 0x41uy; 0x49uy; 0x49uy; 0x7auy; // 47 G
  0x7fuy; 0x08uy; 0x08uy; 0x08uy; 0x7fuy; // 48 H
  0x00uy; 0x41uy; 0x7fuy; 0x41uy; 0x00uy; // 49 I
  0x20uy; 0x40uy; 0x41uy; 0x3fuy; 0x01uy; // 4a J
  0x7fuy; 0x08uy; 0x14uy; 0x22uy; 0x41uy; // 4b K
  0x7fuy; 0x40uy; 0x40uy; 0x40uy; 0x40uy; // 4c L
  0x7fuy; 0x02uy; 0x0cuy; 0x02uy; 0x7fuy; // 4d M
  0x7fuy; 0x04uy; 0x08uy; 0x10uy; 0x7fuy; // 4e N
  0x3euy; 0x41uy; 0x41uy; 0x41uy; 0x3euy; // 4f O
  0x7fuy; 0x09uy; 0x09uy; 0x09uy; 0x06uy; // 50 P
  0x3euy; 0x41uy; 0x51uy; 0x21uy; 0x5euy; // 51 Q
  0x7fuy; 0x09uy; 0x19uy; 0x29uy; 0x46uy; // 52 R
  0x46uy; 0x49uy; 0x49uy; 0x49uy; 0x31uy; // 53 S
  0x01uy; 0x01uy; 0x7fuy; 0x01uy; 0x01uy; // 54 T
  0x3fuy; 0x40uy; 0x40uy; 0x40uy; 0x3fuy; // 55 U
  0x1fuy; 0x20uy; 0x40uy; 0x20uy; 0x1fuy; // 56 V
  0x3fuy; 0x40uy; 0x38uy; 0x40uy; 0x3fuy; // 57 W
  0x63uy; 0x14uy; 0x08uy; 0x14uy; 0x63uy; // 58 X
  0x07uy; 0x08uy; 0x70uy; 0x08uy; 0x07uy; // 59 Y
  0x61uy; 0x51uy; 0x49uy; 0x45uy; 0x43uy; // 5a Z
  0x00uy; 0x7fuy; 0x41uy; 0x41uy; 0x00uy; // 5b [
  0x02uy; 0x04uy; 0x08uy; 0x10uy; 0x20uy; // 5c 55
  0x00uy; 0x41uy; 0x41uy; 0x7fuy; 0x00uy; // 5d ]
  0x04uy; 0x02uy; 0x01uy; 0x02uy; 0x04uy; // 5e ^
  0x40uy; 0x40uy; 0x40uy; 0x40uy; 0x40uy; // 5f _
  0x00uy; 0x01uy; 0x02uy; 0x04uy; 0x00uy; // 60 `
  0x20uy; 0x54uy; 0x54uy; 0x54uy; 0x78uy; // 61 a
  0x7fuy; 0x48uy; 0x44uy; 0x44uy; 0x38uy; // 62 b
  0x38uy; 0x44uy; 0x44uy; 0x44uy; 0x20uy; // 63 c
  0x38uy; 0x44uy; 0x44uy; 0x48uy; 0x7fuy; // 64 d
  0x38uy; 0x54uy; 0x54uy; 0x54uy; 0x18uy; // 65 e
  0x08uy; 0x7euy; 0x09uy; 0x01uy; 0x02uy; // 66 f
  0x0cuy; 0x52uy; 0x52uy; 0x52uy; 0x3euy; // 67 g
  0x7fuy; 0x08uy; 0x04uy; 0x04uy; 0x78uy; // 68 h
  0x00uy; 0x44uy; 0x7duy; 0x40uy; 0x00uy; // 69 i
  0x20uy; 0x40uy; 0x44uy; 0x3duy; 0x00uy; // 6a j
  0x7fuy; 0x10uy; 0x28uy; 0x44uy; 0x00uy; // 6b k
  0x00uy; 0x41uy; 0x7fuy; 0x40uy; 0x00uy; // 6c l
  0x7cuy; 0x04uy; 0x18uy; 0x04uy; 0x78uy; // 6d m
  0x7cuy; 0x08uy; 0x04uy; 0x04uy; 0x78uy; // 6e n
  0x38uy; 0x44uy; 0x44uy; 0x44uy; 0x38uy; // 6f o
  0x7cuy; 0x14uy; 0x14uy; 0x14uy; 0x08uy; // 70 p
  0x08uy; 0x14uy; 0x14uy; 0x18uy; 0x7cuy; // 71 q
  0x7cuy; 0x08uy; 0x04uy; 0x04uy; 0x08uy; // 72 r
  0x48uy; 0x54uy; 0x54uy; 0x54uy; 0x20uy; // 73 s
  0x04uy; 0x3fuy; 0x44uy; 0x40uy; 0x20uy; // 74 t
  0x3cuy; 0x40uy; 0x40uy; 0x20uy; 0x7cuy; // 75 u
  0x1cuy; 0x20uy; 0x40uy; 0x20uy; 0x1cuy; // 76 v
  0x3cuy; 0x40uy; 0x30uy; 0x40uy; 0x3cuy; // 77 w
  0x44uy; 0x28uy; 0x10uy; 0x28uy; 0x44uy; // 78 x
  0x0cuy; 0x50uy; 0x50uy; 0x50uy; 0x3cuy; // 79 y
  0x44uy; 0x64uy; 0x54uy; 0x4cuy; 0x44uy; // 7a z
  0x00uy; 0x08uy; 0x36uy; 0x41uy; 0x00uy; // 7b {
  0x00uy; 0x00uy; 0x7fuy; 0x00uy; 0x00uy; // 7c |
  0x00uy; 0x41uy; 0x36uy; 0x08uy; 0x00uy; // 7d }
  0x10uy; 0x08uy; 0x08uy; 0x10uy; 0x08uy; // 7e ~
  0x78uy; 0x46uy; 0x41uy; 0x46uy; 0x78uy; |]
