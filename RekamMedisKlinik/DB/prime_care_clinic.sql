-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.30 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for prime_care_clinic
DROP DATABASE IF EXISTS `prime_care_clinic`;
CREATE DATABASE IF NOT EXISTS `prime_care_clinic` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `prime_care_clinic`;

-- Dumping structure for view prime_care_clinic.appointment
DROP VIEW IF EXISTS `appointment`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `appointment` 
) ENGINE=MyISAM;

-- Dumping structure for table prime_care_clinic.appointments
DROP TABLE IF EXISTS `appointments`;
CREATE TABLE IF NOT EXISTS `appointments` (
  `id_appointment` int unsigned NOT NULL AUTO_INCREMENT,
  `doctor_id` int unsigned DEFAULT NULL,
  `patient_id` int unsigned DEFAULT NULL,
  `date` date DEFAULT NULL,
  `room` varchar(100) DEFAULT NULL,
  `photo` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_appointment`) USING BTREE,
  KEY `FK_appointments_doctors` (`doctor_id`,`patient_id`) USING BTREE,
  KEY `FK_appointments_patients` (`patient_id`),
  CONSTRAINT `FK_appointments_doctors` FOREIGN KEY (`doctor_id`) REFERENCES `doctors` (`id_doctor`),
  CONSTRAINT `FK_appointments_patients` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id_patient`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table prime_care_clinic.appointments: ~2 rows (approximately)
REPLACE INTO `appointments` (`id_appointment`, `doctor_id`, `patient_id`, `date`, `room`, `photo`) VALUES
	(7, 1, 4, '2025-01-12', 'RG001/GD001', 'IMG_20250112174217.png'),
	(9, 8, 2, '2025-01-23', 'KMR01/GD01', 'IMG_20250113144125.png');

-- Dumping structure for view prime_care_clinic.doctor
DROP VIEW IF EXISTS `doctor`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `doctor` 
) ENGINE=MyISAM;

-- Dumping structure for table prime_care_clinic.doctors
DROP TABLE IF EXISTS `doctors`;
CREATE TABLE IF NOT EXISTS `doctors` (
  `id_doctor` int unsigned NOT NULL AUTO_INCREMENT,
  `user_id` int unsigned DEFAULT NULL,
  `name_doctor` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `sex_doctor` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `address_doctor` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`id_doctor`) USING BTREE,
  KEY `FK_doctors_users` (`user_id`),
  CONSTRAINT `FK_doctors_users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table prime_care_clinic.doctors: ~3 rows (approximately)
REPLACE INTO `doctors` (`id_doctor`, `user_id`, `name_doctor`, `sex_doctor`, `address_doctor`) VALUES
	(1, 2, 'Dr. Muhammad Bintang ', 'laki-laki', 'Jl Perintis Kemerdekaan Km 18'),
	(8, 14, 'Dr Fery', 'laki-laki', 'Jl Perintis');

-- Dumping structure for view prime_care_clinic.medical_record
DROP VIEW IF EXISTS `medical_record`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `medical_record` 
) ENGINE=MyISAM;

-- Dumping structure for table prime_care_clinic.medical_records
DROP TABLE IF EXISTS `medical_records`;
CREATE TABLE IF NOT EXISTS `medical_records` (
  `id_medical_record` int unsigned NOT NULL AUTO_INCREMENT,
  `patient_id` int unsigned NOT NULL DEFAULT '0',
  `doctor_id` int unsigned NOT NULL DEFAULT '0',
  `diagnosis` varchar(200) NOT NULL DEFAULT '0',
  `recipe` varchar(100) NOT NULL DEFAULT '0',
  `price` varchar(100) NOT NULL DEFAULT '0',
  `treatment` varchar(50) NOT NULL DEFAULT '0',
  `date_medical` date DEFAULT NULL,
  PRIMARY KEY (`id_medical_record`) USING BTREE,
  KEY `FK_medical_records_doctors` (`doctor_id`),
  KEY `FK_medical_records_patients` (`patient_id`),
  CONSTRAINT `FK_medical_records_doctors` FOREIGN KEY (`doctor_id`) REFERENCES `doctors` (`id_doctor`),
  CONSTRAINT `FK_medical_records_patients` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id_patient`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table prime_care_clinic.medical_records: ~1 rows (approximately)
REPLACE INTO `medical_records` (`id_medical_record`, `patient_id`, `doctor_id`, `diagnosis`, `recipe`, `price`, `treatment`, `date_medical`) VALUES
	(39, 2, 8, 'askldfjasf', 'sdfalsfd', 'asjdfklajfkls', 'aksjdfaklfa', '2025-01-13');

-- Dumping structure for view prime_care_clinic.patient
DROP VIEW IF EXISTS `patient`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `patient` 
) ENGINE=MyISAM;

-- Dumping structure for table prime_care_clinic.patients
DROP TABLE IF EXISTS `patients`;
CREATE TABLE IF NOT EXISTS `patients` (
  `id_patient` int unsigned NOT NULL AUTO_INCREMENT,
  `name_patient` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `address_patient` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `birth_date` date DEFAULT NULL,
  `sex_patient` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `phone_number` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_patient`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table prime_care_clinic.patients: ~4 rows (approximately)
REPLACE INTO `patients` (`id_patient`, `name_patient`, `address_patient`, `birth_date`, `sex_patient`, `phone_number`) VALUES
	(1, 'Pak Bahlil ', 'Jl Arunteko No 18, Bumi Permata Sudiang', '2000-01-09', 'laki-laki', '08623472343'),
	(2, 'Pak Putu', 'Jl Perintis Kemerdekaan Km 18, Biringkanayaa', '2001-02-09', 'laki-laki', '088324782374'),
	(4, 'Bintang', 'Jl Perintis Kemerdekaan Km 18', '2004-12-02', 'laki-laki', '08234823487'),
	(5, 'Fery Fadul Rahman', 'Jl Perintis', '2004-12-02', 'laki-laki', '08234837453');

-- Dumping structure for table prime_care_clinic.payments
DROP TABLE IF EXISTS `payments`;
CREATE TABLE IF NOT EXISTS `payments` (
  `id_payment` int unsigned NOT NULL AUTO_INCREMENT,
  `patient_id` int unsigned DEFAULT '0',
  `medical_record_id` int unsigned DEFAULT '0',
  `appointment_id` int unsigned DEFAULT '0',
  `status` enum('UNPAID','PAID') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `payment_date` date DEFAULT NULL,
  PRIMARY KEY (`id_payment`) USING BTREE,
  KEY `FK_payments_patients` (`patient_id`),
  KEY `FK_payments_medical_records` (`medical_record_id`),
  KEY `FK_payments_appointments` (`appointment_id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table prime_care_clinic.payments: ~1 rows (approximately)
REPLACE INTO `payments` (`id_payment`, `patient_id`, `medical_record_id`, `appointment_id`, `status`, `payment_date`) VALUES
	(26, 2, 39, 9, 'PAID', '2025-01-26');

-- Dumping structure for table prime_care_clinic.users
DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id_user` int unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(100) DEFAULT NULL,
  `password` varchar(30) DEFAULT NULL,
  `role` varchar(30) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `avatar` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`id_user`) USING BTREE,
  UNIQUE KEY `UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table prime_care_clinic.users: ~4 rows (approximately)
REPLACE INTO `users` (`id_user`, `username`, `password`, `role`, `email`, `avatar`) VALUES
	(1, 'bintang admin', 'admin123', 'admin', 'muhbintang650@gmail.com', NULL),
	(2, 'bintang dokter', 'dokterdokter', 'dokter', 'bintangdokter@gmail.com', NULL),
	(14, 'fery fadul rahman', 'dokterdokter', 'dokter', 'ferydokter@gmail.com', NULL);

-- Dumping structure for view prime_care_clinic.appointment
DROP VIEW IF EXISTS `appointment`;
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `appointment`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `appointment` AS select `appointments`.`id_appointment` AS `id_appointment`,`appointments`.`doctor_id` AS `doctor_id`,`appointments`.`patient_id` AS `patient_id`,`appointments`.`date` AS `date`,`appointments`.`room` AS `room`,`patients`.`id_patient` AS `id_patient`,`patients`.`name_patient` AS `name_patient`,`patients`.`address_patient` AS `address_patient`,`patients`.`birth_date` AS `birth_date`,`patients`.`sex_patient` AS `sex_patient`,`patients`.`phone_number` AS `phone_number`,`patients`.`photo` AS `photo`,`doctors`.`id_doctor` AS `id_doctor`,`doctors`.`user_id` AS `user_id`,`doctors`.`name_doctor` AS `name_doctor`,`doctors`.`sex_doctor` AS `sex_doctor`,`doctors`.`address_doctor` AS `address_doctor` from ((`appointments` join `patients` on((`appointments`.`patient_id` = `patients`.`id_patient`))) join `doctors` on((`appointments`.`doctor_id` = `doctors`.`id_doctor`)));

-- Dumping structure for view prime_care_clinic.doctor
DROP VIEW IF EXISTS `doctor`;
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `doctor`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `doctor` AS select `doctors`.`id_doctor` AS `id_doctor`,`doctors`.`user_id` AS `user_id`,`doctors`.`name` AS `name`,`doctors`.`sex` AS `sex`,`doctors`.`address` AS `address`,`users`.`id_user` AS `id_user`,`users`.`username` AS `username`,`users`.`password` AS `password`,`users`.`role` AS `role`,`users`.`email` AS `email`,`users`.`avatar` AS `avatar` from (`doctors` join `users` on((`doctors`.`user_id` = `users`.`id_user`)));

-- Dumping structure for view prime_care_clinic.medical_record
DROP VIEW IF EXISTS `medical_record`;
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `medical_record`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `medical_record` AS select `medical_records`.`id_medical_record` AS `id_medical_record`,`medical_records`.`patient_id` AS `patient_id`,`medical_records`.`doctor_id` AS `doctor_id`,`medical_records`.`diagnosis` AS `diagnosis`,`medical_records`.`recipe` AS `recipe`,`medical_records`.`price` AS `price`,`medical_records`.`treatment` AS `treatment`,`doctors`.`id_doctor` AS `id_doctor`,`doctors`.`user_id` AS `user_id`,`doctors`.`name_doctor` AS `name_doctor`,`doctors`.`sex_doctor` AS `sex_doctor`,`doctors`.`address_doctor` AS `address_doctor`,`patients`.`id_patient` AS `id_patient`,`patients`.`name_patient` AS `name_patient`,`patients`.`address_patient` AS `address_patient`,`patients`.`birth_date` AS `birth_date`,`patients`.`sex_patient` AS `sex_patient`,`patients`.`phone_number` AS `phone_number`,`patients`.`photo` AS `photo`,`medical_records`.`date_medical` AS `date_medical` from ((`medical_records` join `doctors` on((`medical_records`.`doctor_id` = `doctors`.`id_doctor`))) join `patients` on((`medical_records`.`patient_id` = `patients`.`id_patient`)));

-- Dumping structure for view prime_care_clinic.patient
DROP VIEW IF EXISTS `patient`;
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `patient`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `patient` AS select `patients`.`id_patient` AS `id_patient`,`patients`.`name_patient` AS `name_patient`,`patients`.`address_patient` AS `address_patient`,`patients`.`birth_date` AS `birth_date`,`patients`.`sex_patient` AS `sex_patient`,`patients`.`phone_number` AS `phone_number`,`patients`.`photo` AS `photo` from `patients`;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
