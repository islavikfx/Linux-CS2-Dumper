#!/bin/bash
#!github.com/islavikfx

if [ "$(whoami)" != "root" ]; then
    echo "> Abort. Run script with sudo."
    exit 1
fi

if ! pgrep -f cs2 > /dev/null; then
    echo "> Abort. Run CS2 before script."
    exit 1
fi

if [ ! -f /tmp/m.tmpf ]; then
    echo "> [+] Installing libs.."
    apt update && apt install -y git cmake build-essential
    touch /tmp/m.tmpf
fi

ver=$(find /home -name "steam.inf" 2>/dev/null | grep "csgo" | head -1 | xargs -d '\n' grep "PatchVersion" 2>/dev/null | cut -d'=' -f2)
ver=$(echo "$ver" | tr -d '\r')
echo "CS2 version: $ver"

who=$(getent passwd 1000 | cut -d: -f1)
dirc="/home/$who"

rm -rf /root/Linux-CS2-Dumper
rm -rf "$dirc/Linux-CS2-Dumper"

git clone https://github.com/islavikfx/Linux-CS2-Dumper.git "$dirc/Linux-CS2-Dumper"

cd "$dirc/Linux-CS2-Dumper"
mkdir -p build
cd build
cmake ..
make -j$(nproc)
./CS2DumperBeta

cd "$dirc/Linux-CS2-Dumper/build/output/"
mv "libclient_dump.cs" "libclient_dump(${ver}).cs"
sed -i "s/\[Input\]/$ver/g" "libclient_dump(${ver}).cs"

chmod 666 "$dirc/Linux-CS2-Dumper"
chown -R "$who:$who" "$dirc/Linux-CS2-Dumper"
echo "[+] File: $dirc/Linux-CS2-Dumper/build/output/libclient_dump(${ver}).cs"
