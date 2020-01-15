#!/bin/bash

pushd /workspace/uno.blazor.native.todoapp/src/MyApp.Wasm

export NUGET_PACKAGES=/workspace/.nuget

GITPOD_HOSTNAME=`echo $GITPOD_WORKSPACE_URL | sed -s 's/https:\/\///g'`

msbuild /r /bl src/TodoApp.Wasm/TodoApp.Wasm.csproj /p:UnoSourceGeneratorUseGenerationHost=true /p:UnoSourceGeneratorUseGenerationController=false /p:UnoRemoteControlPort=443 "/p:UnoRemoteControlHost=53487-$GITPOD_HOSTNAME"

popd
