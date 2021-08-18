# spotifyDownloader
spotifyDownloader is an open source Spofity downloader based [Downtify](https://github.com/Shawak/downtify), which makes it possible to download all your favourite songs, 
playlists or songs artwork directly from spotify.

![](https://i.imgur.com/81K7O4q.png)

## Usage

To use spotifyDownloader, you need a clientid, clientSecret key from [Spotify Developer](https://developer.spotify.com/dashboard) and a Spotify Premium account (You can use Premium Family instead).

After that, enter all into the `config.xml`.
```xml
<configuration>
  <username>spotifyLoginDetail_emailOrUserNamehere</username>
  <password>spotifyLoginDetail_passwordHere</password>
  <language>en</language>
  <file_exists>SKIP</file_exists>
  <clientId>your_client_id_here</clientId>
  <clientSecret>your_clientScret_here</clientSecret>
  <volume_normalization>false</volume_normalization>
</configuration>
```

if you don't have premium, don't worry, listen online instead hehe

tiếng việt: nếu bạn không có pre?
```
... không làm mà đòi có ăn...
    thì ăn đb, ăn c...
                       ~ Trích Huấn Rose ~
```
## Developing
Please make sure you have the following prerequisites:

- A desktop platform with the [.NET 4.6.1](https://dotnet.microsoft.com/download) or higher installed.
- We recommend using an IDE with intelligent code completion and syntax highlighting, such as [Visual Studio 2019+](https://visualstudio.microsoft.com/vs/)

### Downloading the source code
Clone the repository:
```shell
git clone https://github.com/michioxd/spotifyDownloader
cd spotifyDownloader
```

To update the source code to the latest commit, run the following command inside the `spotifyDownloader` directory:

```shell
git pull
```

## License

spotifyDownloader is licensed under the GNU General Public License v3, for more information please check out the [license information](https://github.com/michioxd/spotifyDownloader/blob/master/LICENSE).
