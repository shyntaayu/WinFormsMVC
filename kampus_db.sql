-- Buat database
CREATE DATABASE kampus_db;

-- Connect ke database kampus_db, lalu buat tabel
CREATE TABLE mahasiswa (
    id SERIAL PRIMARY KEY,
    nim VARCHAR(20) UNIQUE NOT NULL,
    nama VARCHAR(100) NOT NULL,
    jurusan VARCHAR(50) NOT NULL,
    ipk DECIMAL(3,2) NOT NULL CHECK (ipk >= 0 AND ipk <= 4),
    status VARCHAR(20) DEFAULT 'Aktif'
);

-- Create index untuk performa lebih baik
CREATE INDEX idx_mahasiswa_nim ON mahasiswa(nim);
CREATE INDEX idx_mahasiswa_jurusan ON mahasiswa(jurusan);
CREATE INDEX idx_mahasiswa_ipk ON mahasiswa(ipk);

-- Insert sample data
INSERT INTO mahasiswa (nim, nama, jurusan, ipk, status) VALUES
('210411100001', 'Andi Wijaya', 'Informatika', 3.50, 'Aktif'),
('210411100002', 'Budi Santoso', 'Sistem Informasi', 2.60, 'Aktif'),
('210411100003', 'Citra Dewi', 'Informatika', 3.80, 'Aktif'),
('210411100004', 'Dina Amalia', 'Teknologi Informasi', 3.20, 'Aktif'),
('210411100005', 'Eko Prasetyo', 'Informatika', 2.40, 'Aktif');

-- Query untuk cek data
SELECT * FROM mahasiswa;
SELECT * FROM mahasiswa WHERE ipk >= 3.0 ORDER BY ipk DESC;
SELECT jurusan, COUNT(*) as jumlah FROM mahasiswa GROUP BY jurusan;