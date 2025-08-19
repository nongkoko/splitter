# 🔪 splitter — Bikin PATH Lebih Manusiawi

Pernah ketik `echo %PATH%` di Command Prompt dan langsung pusing lihat hasilnya? Satu baris panjang penuh titik koma, susah dibaca, susah dicari. `splitter` hadir untuk menyelamatkan hari Anda.

## 🚀 Fitur Utama

- ✅ **Split string berdasarkan delimiter** — default-nya `;`, cocok untuk environment variable seperti `PATH`
- ✅ **Input fleksibel via stdin** — tinggal pipe dari `echo`, `type`, atau command lain
- ✅ **Argumen command-line modular** — bisa ganti delimiter sesuai kebutuhan
- ✅ **Output bersih dan terstruktur** — satu item per baris, langsung terbaca

## 🧪 Contoh Penggunaan

```bash
echo %PATH% | splitter.exe
