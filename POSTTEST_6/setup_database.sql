-- ============================================================
-- SETUP DATABASE: db_barbershop
-- POSTTEST-6 — Database Relation (VB.NET + MySQL)
-- ============================================================

CREATE DATABASE IF NOT EXISTS db_barbershop;
USE db_barbershop;

-- ============================================================
-- TABEL INDUK (Parent): tbpelanggan
-- ============================================================
CREATE TABLE IF NOT EXISTS tbpelanggan (
    kodePelanggan   VARCHAR(10)  NOT NULL,
    namaPelanggan   VARCHAR(100) NOT NULL,
    noTelepon       VARCHAR(15)  NOT NULL,
    alamat          VARCHAR(255),
    PRIMARY KEY (kodePelanggan)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ============================================================
-- TABEL ANAK (Child): tbpelayanan
-- kodePelanggan = FOREIGN KEY → tbpelanggan.kodePelanggan
-- ON DELETE CASCADE : jika pelanggan dihapus, semua pelayanannya ikut terhapus
-- ON UPDATE CASCADE : jika kode pelanggan diubah, kode di tbpelayanan ikut berubah
-- ============================================================
CREATE TABLE IF NOT EXISTS tbpelayanan (
    kodePelayanan   VARCHAR(10)  NOT NULL,
    kodePelanggan   VARCHAR(10)  NOT NULL,
    jenisPemotongan VARCHAR(100) NOT NULL,
    harga           INT          NOT NULL,
    tanggal         DATE         NOT NULL,
    PRIMARY KEY (kodePelayanan),
    CONSTRAINT fk_pelayanan_pelanggan
        FOREIGN KEY (kodePelanggan)
        REFERENCES tbpelanggan (kodePelanggan)
        ON DELETE CASCADE
        ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ============================================================
-- DATA CONTOH
-- ============================================================
INSERT INTO tbpelanggan VALUES
  ('P001', 'Budi Santoso',    '081234567890', 'Jl. Merdeka No. 1'),
  ('P002', 'Arif Rahman',     '082345678901', 'Jl. Sudirman No. 5'),
  ('P003', 'Deni Firmansyah', '083456789012', 'Jl. Diponegoro No. 3');

INSERT INTO tbpelayanan VALUES
  ('SV001', 'P001', 'Fade Cut',       45000, '2025-04-10'),
  ('SV002', 'P002', 'Cukur Reguler',  25000, '2025-04-11'),
  ('SV003', 'P001', 'Cukur Jenggot',  20000, '2025-04-12'),
  ('SV004', 'P003', 'Full Package (Rambut + Jenggot + Kumis)', 80000, '2025-04-13');
