#!/bin/bash
pushd /workspace/uno.blazor.native.todoapp/src/TodoApp.Wasm/bin/Debug/netstandard2.0/dist

python3 server.py

popd

