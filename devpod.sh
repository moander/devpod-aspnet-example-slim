#!/bin/bash

dotnet restore

cd src/devpod-aspnet-example-slim

dotnet run --server.urls=http://*:5000


