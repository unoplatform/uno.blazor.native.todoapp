#!/bin/bash
pushd /workspace/uno.blazor.native.todoapp/src/TodoApp.Wasm/bin/Debug/netstandard2.1/dist

python3 server.py

popd

