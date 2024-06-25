<div style="display: flex;">
<img src="https://shields.io/badge/Windows--9cf?logo=Windows&style=social">
<img src="https://img.shields.io/badge/CODE-%3C.NET%204.8%3E%20%3CC%23%3E-darkblue?style=plastic&labelColor=66ccff">

</div>

# yt-dlp-GUI
Easy GUI for yt-dlp. 
### I don't take any responsibility caused by using this application!!<br/>
### このアプリケーションの使用により生じる一切の責任を負いません!!<br/>
バージョン2.0.0からはPythonからC#に移行を行いました。

このアプリケーションでは、実行時に必須と言っていいほどの`--no-time`などの引数が予めついているため便利です。

# Installation/インストール
あまり詳しくない場合はパッケージ版をおすすめします。

・パッケージ版の導入方法

1.[**ここ**](https://github.com/AkaakuHub/yt-dlp-GUI/releases/latest)にある最新バージョンのリリース("Latest"と書いてあるもの)から
```yt-dlp-GUI.zip```
をダウンロードし、アプリケーションを配置したい場所で展開する。<br><br>
2.[**ここ**](https://github.com/yt-dlp/yt-dlp/releases)にある最新バージョンのリリース("Latest"と書いてあるもの)から
```yt-dlp.exe```
をダウンロードし、それをユーザーディレクトリ(例.Windowsの場合、C:\\Users\\ユーザー名\\
)に移動する。<br><br>
3.[**ここ**](https://github.com/yt-dlp/FFmpeg-Builds/releases/)にある最新バージョンのリリース("Latest"と書いてあるもの)から
```ffmpeg-master-latest-win64-gpl.zip```
をダウンロードし、展開してから、
```ffmpeg.exe```と```ffprobe.exe```
を2番と同じユーザーディレクトリに移動する。<br><br>

# How to use/使い方

## 初心者向け
yt-dlp-GUI.exeを押して起動します。<br>
初回使用の場合、まず左上の設定 > 環境設定 > 保存先を選んで保存先ディレクトリを登録してください。デフォルトではユーザー配下のビデオになっています。<br>

アプリを起動し、URLを入力したら任意のボタンを押すと実行できます。<br>
よく分からない場合は高品質ダウンロードで良いです。

## 中級者向け
まず、「リストを表示」を実行して、コーデックIDの一覧を取得します。次に、希望のコーデックIDを入力し、「リストからコーデックIDを指定」を実行します。
- 例1: 140番がほしい → `140`
- 例2: 140番と270番をまとめて1つのファイルでほしい → `140+270`

また、コーデックIDは優先順位をつけて書くことも出来ます。
- 例: `247+251/136+140/22+43/382+385/398+401/298+300/612+614`

# Trouble Shooting/トラブルシューティング

## 「yt-dlp/ffmpegがインストールされていないか、パスが通っていません。表示される手順に従ってパスを通してください。」と表示される

まず、インストール手順に従ってダウンロードしているか確認してください。

ユーザーディレクトリにyt-dlpやffmpegなどのexeがあるのにエラーが出る場合は、以下の手順に従って、パスを通してください。

1. Windowsマークを押し、検索欄に「環境変数」と入力し、「環境変数を編集」を実行する。

2. 上半分側で、1列目の変数が「Path」となっている部分をダブルクリックする。

3. 「環境変数名の編集」のウィンドウが開いたら、「新規」をクリックして、以下のように入力する。<br/>例：ユーザー名が「guest」の場合、`C:\Users\guest`

4. 「OK」を2つ押してウィンドウを閉じる。
