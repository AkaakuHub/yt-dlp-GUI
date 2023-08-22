import tkinter as tk
import subprocess
import threading
DIR = "C:\\Users\\ユーザー名\\Videos\\yt-dlp-data"
BROWSER = "firefox"
VERSION = "ver 1.2.1"


def run_command(command):
    try:
        run_show.delete(1.0, tk.END)
        run_show.insert(tk.END, "True")
        run_frame.configure(bg="Red")
        run_label.configure(bg="Red")
        process = subprocess.Popen(
            command,
            shell=True,
            text=True,
            stderr=subprocess.PIPE,
            stdout=subprocess.PIPE,
            encoding="utf-8",
            errors="ignore",
        )

        # コマンドの実行結果を逐次表示
        for line in process.stdout:
            results_text.insert(tk.END, line)
            results_text.see(tk.END)

        process.wait()

    except subprocess.CalledProcessError as e:
        results_text.insert(tk.END, f"Error: {e.output}\n")

    run_show.delete(1.0, tk.END)
    run_show.insert(tk.END, "False")
    run_frame.configure(bg="aquamarine")
    run_label.configure(bg="aquamarine")


def execute_command(kind):
    global results_text
    url = url_entry.get()
    lang = lang_entry.get()
    num = num_entry.get()
    if kind == 1:
        command = f'yt-dlp -f "bestvideo[ext=mp4]+bestaudio[ext=m4a]" -o "{DIR}\\%(title)s.%(ext)s" --no-mtime {url}'
    elif kind == 2:
        command = f'yt-dlp -f "bestaudio[ext=m4a]" -o "{DIR}\\%(title)s.%(ext)s" --no-mtime {url}'
    elif kind == 3:
        command = f'yt-dlp -f "bestvideo[ext=mp4]+bestaudio[ext=m4a]/best[ext=mp4]/best" -o "{DIR}\\%(title)s.%(ext)s" --no-mtime {url}'
    elif kind == 4:
        command = f'yt-dlp -o "{DIR}\\%(title)s.%(ext)s" --no-mtime {url}'
    elif kind == 5:
        command = f'yt-dlp -o "{DIR}\\%(title)s.%(ext)s" --write-auto-sub --sub-lang {lang} --skip-download {url}'
    elif kind == 6:
        command = f"yt-dlp --list-formats {url}"
    elif kind == 7:
        command = f'yt-dlp -f {num} -o "{DIR}\\%(title)s.%(ext)s" --no-mtime {url}'
    elif kind == 8:
        command = f'yt-dlp -o "{DIR}\\%(title)s.%(ext)s" --live-from-start {url}'
    elif kind == 9:
        command = f'yt-dlp -f "bestaudio[ext=m4a]" -o "{DIR}\\%(title)s.%(ext)s" --no-mtime --cookies-from-browser {BROWSER} {url}'
    elif kind == 10:
        command = f"yt-dlp --list-formats --cookies-from-browser {BROWSER} {url}"
    elif kind == 11:
        command = f'yt-dlp -f {num} -o "{DIR}\\%(title)s.%(ext)s" --no-mtime --cookies-from-browser {BROWSER} {url}'

    # コマンド実行を非同期に行うためのスレッドを開始
    thread = threading.Thread(target=run_command, args=(command,))
    thread.start()


# GUIの設定
root = tk.Tk()
root.title("yt-dlpコマンド実行GUI")
# root.attributes("-fullscreen", True)
root.geometry("1920x1080")

wrapper = tk.Frame(root, padx=5, pady=5, width=700, height=600, bg="gray100")
wrapper.pack()

############################################

input_frame = tk.Frame(wrapper, padx=5, pady=5, width=350, bg="gray100")
input_frame.pack(side=tk.LEFT)

# title
title_frame = tk.Frame(
    input_frame, padx=5, pady=5, bg="LightBlue", relief=tk.GROOVE, bd=5
)
title_frame.pack(anchor=tk.N)
title_label = tk.Label(
    title_frame, text="yt-dlpコマンド実行GUI", font=("Arial", 22), anchor=tk.W, bg="LightBlue"
)
title_label.pack(side=tk.LEFT)

version = tk.Label(input_frame, text=f"{VERSION}", font=("Arial", 16), bg="gray100")
version.pack()

br = tk.Label(input_frame, text="\n", font=("Arial", 32), bg="gray100")
br.pack()

# URL入力欄
url_frame = tk.Frame(input_frame, padx=5, pady=5, bg="LightPink", relief=tk.RIDGE, bd=5)
url_frame.pack(anchor=tk.W)
url_label = tk.Label(
    url_frame, text="URL\nここで", font=("Arial", 16), anchor=tk.W, bg="LightPink"
)
url_label.pack(side=tk.LEFT)
url_entry = tk.Entry(url_frame, width=50)
url_entry.pack(side=tk.LEFT)

br = tk.Label(input_frame, text="\n", font=("Arial", 16), bg="gray100")
br.pack()

# lang入力欄
lang_frame = tk.Frame(
    input_frame, padx=5, pady=5, bg="alice blue", relief=tk.RIDGE, bd=5
)
lang_frame.pack(anchor=tk.W)
lang_label = tk.Label(
    lang_frame, text="lang", font=("Arial", 16), anchor=tk.W, bg="alice blue"
)
lang_label.pack(side=tk.LEFT)
lang_entry = tk.Entry(lang_frame, width=10)
lang_entry.pack(side=tk.LEFT)

lang_entry.insert(0, "ja")

# num入力欄
num_frame = tk.Frame(
    input_frame, padx=5, pady=5, bg="LightGreen", relief=tk.RIDGE, bd=5
)
num_frame.pack(anchor=tk.W)
num_label = tk.Label(
    num_frame, text="num", font=("Arial", 16), anchor=tk.W, bg="LightGreen"
)
num_label.pack(side=tk.LEFT)
num_entry = tk.Entry(num_frame, width=10)
num_entry.pack(side=tk.LEFT)

br = tk.Label(input_frame, text="\n", font=("Arial", 16), bg="gray100")
br.pack()

# isRunning欄
run_frame = tk.Frame(
    input_frame, padx=5, pady=5, bg="aquamarine", relief=tk.RIDGE, bd=5
)
run_frame.pack(anchor=tk.W)
run_label = tk.Label(
    run_frame, text="isRunning", font=("Arial", 16), anchor=tk.W, bg="aquamarine"
)
run_label.pack(side=tk.LEFT)
run_show = tk.Text(run_frame, height=1, width=10, font=("Arial", 24))
run_show.pack(side=tk.LEFT)

run_show.insert(tk.END, "False")

############################################

button_frame = tk.Frame(wrapper, padx=5, pady=5, width=350, bg="gray100")
button_frame.pack(side=tk.RIGHT)

# ボタン1
frame1 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame1.pack(anchor=tk.W)
text_label1 = tk.Label(
    frame1, text="通常ダウンロード", font=("Arial", 12), anchor=tk.W, bg="gray100"
)
text_label1.pack(side=tk.LEFT)
execute_button_1 = tk.Button(
    frame1,
    text="実行",
    command=lambda: execute_command(1),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_1.pack(side=tk.LEFT)

# ボタン2
frame2 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame2.pack(anchor=tk.W)
text_label2 = tk.Label(
    frame2, text="音声ダウンロード", font=("Arial", 12), anchor=tk.W, bg="gray100"
)
text_label2.pack(side=tk.LEFT)
execute_button_2 = tk.Button(
    frame2,
    text="実行",
    command=lambda: execute_command(2),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_2.pack(side=tk.LEFT)

# ボタン3
frame3 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame3.pack(anchor=tk.W)
text_label3 = tk.Label(frame3, text="高品質ダウンロード", font=("Arial", 12), bg="gray100")
text_label3.pack(side=tk.LEFT)
execute_button_3 = tk.Button(
    frame3,
    text="実行",
    command=lambda: execute_command(3),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_3.pack(side=tk.LEFT)

# ボタン4
frame4 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame4.pack(anchor=tk.W)
text_label4 = tk.Label(
    frame4, text="フォーマットが非対応の場合(自動でフォーマットが選ばれます)", font=("Arial", 12), bg="gray100"
)
text_label4.pack(side=tk.LEFT)
execute_button_4 = tk.Button(
    frame4,
    text="実行",
    command=lambda: execute_command(4),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_4.pack(side=tk.LEFT)

# ボタン5
frame5 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame5.pack(anchor=tk.W)
text_label5 = tk.Label(frame5, text="字幕のみダウンロード", font=("Arial", 12), bg="gray100")
text_label5.pack(side=tk.LEFT)
execute_button_5 = tk.Button(
    frame5,
    text="実行",
    command=lambda: execute_command(5),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_5.pack(side=tk.LEFT)

# ボタン6
frame6 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame6.pack(anchor=tk.W)
text_label6 = tk.Label(frame6, text="リストを表示", font=("Arial", 12), bg="gray100")
text_label6.pack(side=tk.LEFT)
execute_button_6 = tk.Button(
    frame6,
    text="実行",
    command=lambda: execute_command(6),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_6.pack(side=tk.LEFT)

# ボタン7
frame7 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame7.pack(anchor=tk.W)
text_label7 = tk.Label(
    frame7, text="フォーマットを指定してダウンロード", font=("Arial", 12), bg="gray100"
)
text_label7.pack(side=tk.LEFT)
execute_button_7 = tk.Button(
    frame7,
    text="実行",
    command=lambda: execute_command(7),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_7.pack(side=tk.LEFT)

# ボタン8
frame8 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame8.pack(anchor=tk.W)
text_label8 = tk.Label(frame8, text="配信を録画", font=("Arial", 12), bg="gray100")
text_label8.pack(side=tk.LEFT)
execute_button_8 = tk.Button(
    frame8,
    text="実行",
    command=lambda: execute_command(8),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_8.pack(side=tk.LEFT)

# ボタン9
frame9 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame9.pack(anchor=tk.W)
text_label9 = tk.Label(
    frame9, text="プレミアムミュージック(要Premium)", font=("Arial", 12), bg="gray100"
)
text_label9.pack(side=tk.LEFT)
execute_button_9 = tk.Button(
    frame9,
    text="実行",
    command=lambda: execute_command(9),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_9.pack(side=tk.LEFT)

# ボタン10
frame10 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame10.pack(anchor=tk.W)
text_label10 = tk.Label(
    frame10, text="プレミアムでリストを表示(要Premium)", font=("Arial", 12), bg="gray100"
)
text_label10.pack(side=tk.LEFT)
execute_button_10 = tk.Button(
    frame10,
    text="実行",
    command=lambda: execute_command(10),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_10.pack(side=tk.LEFT)

# ボタン11
frame11 = tk.Frame(button_frame, padx=5, pady=5, bg="gray100")
frame11.pack(anchor=tk.W)
text_label11 = tk.Label(
    frame11, text="プレミアムでフォーマットを指定してダウンロード(要Premium)", font=("Arial", 12), bg="gray100"
)
text_label11.pack(side=tk.LEFT)
execute_button_11 = tk.Button(
    frame11,
    text="実行",
    command=lambda: execute_command(11),
    font=("Arial", 12),
    bg="gray100",
)
execute_button_11.pack(side=tk.LEFT)

####################

results_text = tk.Text(button_frame, width=140, height=25, bg="black", fg="white")
results_text.pack(fill=tk.BOTH, expand=True)

# GUIループの開始
root.mainloop()
