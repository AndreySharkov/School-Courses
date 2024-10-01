# Distributed under the OSI-approved BSD 3-Clause License.  See accompanying
# file Copyright.txt or https://cmake.org/licensing for details.

cmake_minimum_required(VERSION 3.5)

file(MAKE_DIRECTORY
  "C:/Users/andys/esp/esp-idf/components/bootloader/subproject"
  "C:/Users/andys/OneDrive/Desktop/EspIDFProjects/Oled display/i2c_oled/build/bootloader"
  "C:/Users/andys/OneDrive/Desktop/EspIDFProjects/Oled display/i2c_oled/build/bootloader-prefix"
  "C:/Users/andys/OneDrive/Desktop/EspIDFProjects/Oled display/i2c_oled/build/bootloader-prefix/tmp"
  "C:/Users/andys/OneDrive/Desktop/EspIDFProjects/Oled display/i2c_oled/build/bootloader-prefix/src/bootloader-stamp"
  "C:/Users/andys/OneDrive/Desktop/EspIDFProjects/Oled display/i2c_oled/build/bootloader-prefix/src"
  "C:/Users/andys/OneDrive/Desktop/EspIDFProjects/Oled display/i2c_oled/build/bootloader-prefix/src/bootloader-stamp"
)

set(configSubDirs )
foreach(subDir IN LISTS configSubDirs)
    file(MAKE_DIRECTORY "C:/Users/andys/OneDrive/Desktop/EspIDFProjects/Oled display/i2c_oled/build/bootloader-prefix/src/bootloader-stamp/${subDir}")
endforeach()
if(cfgdir)
  file(MAKE_DIRECTORY "C:/Users/andys/OneDrive/Desktop/EspIDFProjects/Oled display/i2c_oled/build/bootloader-prefix/src/bootloader-stamp${cfgdir}") # cfgdir has leading slash
endif()
