# タイマーアプリ Ver.1 解説

## 概要

この C# コードは Windows Forms を用いたタイマーアプリです。

* 時間設定ボタンで分や秒を加算可能
* スタート、ストップ、リセット機能
* タイマー終了時にアラームサウンドを再生
* プログレスバーで進行状況を視覚化
* サウンドファイルが存在しない場合はエラーメッセージ表示

---

## 1. フィールド

```csharp
int h; // 時
int m; // 分
int s; // 秒
int time; // 総時間（ミリ秒）
```

* タイマーの時間管理用

---

## 2. コンストラクタと初期化

```csharp
public Form1()
{
    InitializeComponent();
    timer1.Interval = 1000; // 1秒ごとに Tick
    Init();
    status.Text = "Standby";
    Start.Enabled = false;
    Stop.Enabled = false;
    timeup.Visible = false;
}
```

* タイマーの間隔を設定
* ボタンやラベルの初期状態設定

```csharp
public void Init()
{
    h = 0; m = 0; s = 0; time = 0;
    WriteTimeText();
}
```

* 時間をリセットして表示を更新

```csharp
public void WriteTimeText()
{
    display.Text = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
}
```

* HH:MM:SS形式で表示更新

---

## 3. タイマーの Tick イベント

```csharp
private void timer1_Tick(object sender, EventArgs e)
{
    time = time - 1000; // 1秒減少
    m = time / 60000;
    h = time / (360*100*100); // 計算方法は修正可能
    s = (time % 60000) / 1000;
    WriteTimeText();

    if (time == 0)
    {
        timer1.Stop();
        status.Text = "Time Up";
        status2.Visible = false;
        timeup.Visible = true;
        try { 
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\Alarm.wav");
            simpleSound.Play();
        } catch (System.IO.FileNotFoundException) {
            MessageBox.Show("サウンドファイルが見つかりません。", "エラー");
        }
        Init();
        status.Text = "Standby";
        Start.Enabled = false;
        Stop.Enabled = false;
    }
}
```

* 毎秒カウントダウン
* 0になったらタイマー停止とサウンド再生

---

## 4. スタートボタン

```csharp
private void Start_Click(object sender, EventArgs e)
{
    try {
        SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\notify.wav");
        simpleSound.Play();
    } catch { /* ファイルなしエラー */ }

    time = (h*60*60 + m*60 + s) * 1000; // 秒をミリ秒に変換
    timer1.Start();
    status.Text = "Start";
    status2.Style = ProgressBarStyle.Marquee;
    status2.Maximum = 10;
    status2.MarqueeAnimationSpeed = 30;
    Start.Enabled = false;
    Stop.Enabled = true;
    min1.Enabled = min10.Enabled = min30.Enabled = false;
    sec1.Enabled = sec10.Enabled = sec30.Enabled = false;
}
```

* タイマー開始、ボタン無効化、プログレスバー開始
* サウンド再生

---

## 5. 停止ボタン

```csharp
private void Stop_Click(object sender, EventArgs e)
{
    try { SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\chimes.wav"); simpleSound.Play(); } catch {}
    timer1.Stop();
    status.Text = "Stop";
    status2.MarqueeAnimationSpeed = 0;
    Start.Enabled = true;
    Stop.Enabled = false;
    min1.Enabled = min10.Enabled = min30.Enabled = true;
    sec1.Enabled = sec10.Enabled = sec30.Enabled = true;
}
```

* タイマー停止、ボタン有効化、プログレスバー停止

---

## 6. リセットボタン

```csharp
private void reset_Click(object sender, EventArgs e)
{
    try { SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\chimes.wav"); simpleSound.Play(); } catch {}
    timer1.Stop();
    Init();
    display.Text = "00:00:00";
    status.Text = "Reset";
    Start.Enabled = false;
    Stop.Enabled = false;
    min1.Enabled = min10.Enabled = min30.Enabled = sec1.Enabled = sec10.Enabled = sec30.Enabled = true;
}
```

* 時間リセット、ボタンと表示の初期化
* サウンド再生

---

## 7. 時間設定ボタン（1, 10, 30 秒/分）

* 各ボタンで秒や分を加算
* 60以上になった場合は 0 に戻す
* サウンド再生で操作感を強化

例：1分ボタン

```csharp
if (btn == min1) { m++; if(m>=60) m=0; }
if (btn == sec1) { s++; if(s>=60) s=0; }
WriteTimeText();
```

* 10,30 ボタンも同様の処理で加算量変更

---

## 8. タイムアップ表示

```csharp
private void timeup_Click(object sender, EventArgs e)
{
    try { 
        SoundPlayer simpleSound2 = new SoundPlayer(@"..\..\sound\chimes.wav"); simpleSound2.Play();
    } catch {}
    timeup.Visible = false;
    status2.Visible = true;
}
```

* タイマー終了時のサウンドと表示切り替え

---

## まとめ

* Windows Forms でタイマー作成
* 秒・分のボタンで時間設定可能
* Start/Stop/Reset でタイマー制御
* プログレスバーで進行状況表示
* サウンド再生は `try-catch` で安全に処理
