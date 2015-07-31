#!/bin/sh

VERSION=$1
if [ -z "$VERSION" ]; then
    echo "Must specify version."
    exit 1
fi

zip LiveSplit.DragonAgeInquisition_v${VERSION}.zip LiveSplit.DragonAgeInquisition.dll ../readme.txt
