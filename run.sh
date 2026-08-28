#!/bin/bash
# github.com/islavikfx

cd ~


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
fi

touch /tmp/m.tmpf

ver=$(find /home -name "steam.inf" 2>/dev/null | grep "csgo" | head -1 | xargs -d '\n' grep "PatchVersion" 2>/dev/null | cut -d'=' -f2)
echo "CS2 version: $ver."


if [ ! -d "Linux-CS2-Dumper" ]; then
    git clone https://github.com/islavikfx/Linux-CS2-Dumper.git
    cd Linux-CS2-Dumper/
    mkdir -p build
    cd build/
    cmake ..\\
    make -j$(nproc)
    sudo ./CS2DumperBeta
else
    cd Linux-CS2-Dumper/
    cd build/
    rm -rf output/*
    sudo ./CS2DumperBeta
fi


cd ~/Linux-CS2-Dumper/build/output/
chmod 666 libclient_dump.cs
mv "libclient_dump.cs" "libclient_dump(${ver}).cs"
sed -i "s/Input/$ver/g" "libclient_dump(${ver}).cs"

echo "Done!"