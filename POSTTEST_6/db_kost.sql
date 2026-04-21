-- =====================================================
-- Database: db_kost
-- Sistem Manajemen Kost - POSTTEST 6
-- Mencakup tabel tbkamar dan tbpenyewa (berelasi)
-- =====================================================

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";
SET NAMES utf8mb4;

-- Buat database jika belum ada
CREATE DATABASE IF NOT EXISTS `db_kost`
  CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

USE `db_kost`;

-- --------------------------------------------------------
-- Tabel: tbkamar (Tabel Induk / Parent Table)
-- --------------------------------------------------------
DROP TABLE IF EXISTS `tbpenyewa`;
DROP TABLE IF EXISTS `tbkamar`;

CREATE TABLE `tbkamar` (
  `idKamar`     INT(11)      NOT NULL AUTO_INCREMENT,
  `jenisKamar`  VARCHAR(50)  NOT NULL,
  `nomorKamar`  VARCHAR(10)  NOT NULL,
  `hargaKamar`  INT(11)      NOT NULL DEFAULT 0,
  `statusKamar` VARCHAR(20)  NOT NULL DEFAULT 'Kosong',
  PRIMARY KEY (`idKamar`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data awal tbkamar
INSERT INTO `tbkamar` (`jenisKamar`, `nomorKamar`, `hargaKamar`, `statusKamar`) VALUES
('Standar',  'K01', 500000,  'Kosong'),
('AC',       'K02', 800000,  'Terisi'),
('VIP',      'K03', 1200000, 'Kosong'),
('Standar',  'K04', 500000,  'Terisi'),
('AC',       'K05', 800000,  'Kosong');

-- --------------------------------------------------------
-- Tabel: tbpenyewa (Tabel Anak / Child Table)
-- Berelasi dengan tbkamar melalui Foreign Key idKamar
-- ON DELETE: RESTRICT  (kamar tidak bisa dihapus bila masih ada penyewa)
-- ON UPDATE: CASCADE   (jika idKamar berubah, ikut berubah)
-- --------------------------------------------------------
CREATE TABLE `tbpenyewa` (
  `idPenyewa`    INT(11)      NOT NULL AUTO_INCREMENT,
  `idKamar`      INT(11)      NOT NULL,
  `namaPenyewa`  VARCHAR(100) NOT NULL,
  `noTelp`       VARCHAR(20)  NOT NULL,
  `tanggalMasuk` DATE         NOT NULL,
  `tanggalKeluar`DATE         DEFAULT NULL,
  `statusSewa`   VARCHAR(20)  NOT NULL DEFAULT 'Aktif',
  PRIMARY KEY (`idPenyewa`),
  CONSTRAINT `fk_penyewa_kamar`
    FOREIGN KEY (`idKamar`)
    REFERENCES `tbkamar` (`idKamar`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data awal tbpenyewa
INSERT INTO `tbpenyewa` (`idKamar`, `namaPenyewa`, `noTelp`, `tanggalMasuk`, `statusSewa`) VALUES
(2, 'Budi Santoso',   '08123456789', '2025-01-01', 'Aktif'),
(4, 'Siti Aminah',    '08987654321', '2025-03-15', 'Aktif');

COMMIT;
