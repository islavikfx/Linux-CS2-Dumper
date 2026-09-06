#!/bin/bash
#!github.com/islavikfx

if ! pgrep -f cs2 > /dev/null; then
    echo "> Abort. Run CS2 before script."
    exit 1
fi

ver=$(find /home -name "steam.inf" 2>/dev/null | grep "csgo" | head -1 | xargs -d '\n' grep "PatchVersion" 2>/dev/null | cut -d'=' -f2)
ver=$(echo "$ver" | tr -d '\r')
echo "CS2 version: $ver"

who=$(getent passwd 1000 | cut -d: -f1)
dirc="/home/$who"

sudo rm -rf "$dirc/Linux-CS2-Dumper"

git clone https://github.com/islavikfx/Linux-CS2-Dumper.git "$dirc/Linux-CS2-Dumper"

cd "$dirc/Linux-CS2-Dumper"
mkdir -p build
cd build
cmake ..
make -j$(nproc)
sudo ./CS2DumperBeta

cd "$dirc/Linux-CS2-Dumper/build/output/"
sudo mv "libclient_dump.cs" "libclient_dump(${ver}).cs"
sudo sed -i "s/\[Input\]/$ver/g" "libclient_dump(${ver}).cs"

sudo chmod 666 "libclient_dump(${ver}).cs"
sudo chown -R "$who:$who" "libclient_dump(${ver}).cs"
echo "\n[+] File: $dirc/Linux-CS2-Dumper/build/output/libclient_dump(${ver}).cs"
