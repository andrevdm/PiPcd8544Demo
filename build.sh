#!/bin/sh
fsharpc --out:lcdDemo.exe --target:exe --debug+ --debug:full --tailcalls+ --optimize font.fs wipiInit.fs gpio.fs spi.fs lcd.fs lcdDemo.fs && scp -r lcdDemo* pi@192.168.0.73:~/prog/fs/wiringPi_5110_Basic/
