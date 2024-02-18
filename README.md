# Proyek Kasir Toko

Aplikasi Kasir Toko ini dibuat untuk latihan dalam Lomba Kompetensi Siswa (LKS) Kabupaten Kendal. Aplikasi ini merupakan aplikasi desktop yang dikembangkan menggunakan bahasa pemrograman C#. Aplikasi ini memiliki fitur-fitur utama sebagai berikut:

## Fitur Utama

1. **Autentikasi dan Otorisasi**: Pengguna perlu melakukan login dengan akun yang valid sebelum dapat mengakses fitur-fitur aplikasi. Setiap pengguna memiliki izin akses yang ditentukan oleh peran (role) yang mereka miliki.
   
2. **Master Data Admin**: Fitur untuk manajemen data pengguna aplikasi, termasuk pembuatan, pengeditan, dan penghapusan akun admin.

3. **Master Data Produk**: Modul untuk mengelola data produk di toko, seperti menambah, mengedit, dan menghapus informasi produk.

4. **Master Data Kategori Produk**: Fitur untuk mengelola kategori produk yang tersedia di toko, seperti menambah, mengedit, dan menghapus kategori produk.

5. **Transaksi**: Modul untuk melakukan transaksi penjualan, termasuk penambahan produk ke dalam keranjang belanja, penghitungan total harga, dan pembayaran.

6. **History Transaksi**: Fitur untuk melihat riwayat transaksi yang telah dilakukan oleh toko.

## Teknologi yang Digunakan

- **Database**: Database `tokoonline.bak` akan digunakan untuk menyimpan data aplikasi, termasuk data pengguna, produk, kategori produk, dan riwayat transaksi.
  
- **Pengembangan**: Microsoft Visual Studio 2022 digunakan sebagai lingkungan pengembangan terintegrasi (IDE) untuk membuat aplikasi desktop dengan bahasa pemrograman C#.

## Panduan Instalasi

1. Pastikan Anda memiliki file database `tokoonline.bak`, Microsoft SQL Server Management Studio 2019, dan Microsoft Visual Studio 2022 terinstal di komputer Anda.
   
2. Restore file database `tokoonline.bak` ke dalam SQL Server Management Studio 2019.

3. Clone repositori aplikasi ini ke komputer Anda.

4. Buka solusi proyek dalam Visual Studio 2022.

5. Atur koneksi database pada file konfigurasi aplikasi untuk mengarahkan ke `tokoonline.bak`.

6. Compile dan jalankan aplikasi dalam lingkungan pengembangan.

7. Lakukan konfigurasi awal seperti menambahkan data admin dan data produk sebelum memulai penggunaan aplikasi.

## Kontribusi

Jika Anda ingin berkontribusi pada pengembangan proyek ini, silakan kirimkan pull request melalui repositori GitHub kami.

## Lisensi

Proyek ini dilisensikan di bawah [MIT License](https://opensource.org/licenses/MIT).

