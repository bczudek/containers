FROM mcr.microsoft.com/powershell:6.2.2-alpine-3.8
ENV AZ 2.0.70

RUN apk add -U python3 bash && \
    apk add --virtual=build linux-headers gcc python3-dev musl-dev libffi-dev openssl-dev make --no-cache && \
    pip3 install --upgrade pip && \
    pip3 install azure-cli==${AZ} --no-cache-dir && \
    ln -s /usr/bin/python3 /usr/bin/python && \
    apk del build

RUN pwsh -Command "& {Install-Module -Name Az -AllowClobber -Scope CurrentUser -RequiredVersion 2.5.0 -Force}"