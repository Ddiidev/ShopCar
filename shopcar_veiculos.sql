CREATE SCHEMA IF NOT EXISTS `shopcar`;

-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: shopcar
-- ------------------------------------------------------
-- Server version	8.0.35

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `veiculos`
--
veiculos
USE `shopcar`;

DROP TABLE IF EXISTS `veiculos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `veiculos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `placa` varchar(10) DEFAULT NULL,
  `chassi` varchar(20) DEFAULT NULL,
  `marca` varchar(50) DEFAULT NULL,
  `modelo` varchar(50) DEFAULT NULL,
  `anofabricacao` int DEFAULT NULL,
  `anomodelo` int DEFAULT NULL,
  `valorfipe` decimal(10,2) DEFAULT NULL,
  `valorvenda` decimal(10,2) DEFAULT NULL,
  `observacoes` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculos`
--

LOCK TABLES `veiculos` WRITE;
/*!40000 ALTER TABLE `veiculos` DISABLE KEYS */;
INSERT INTO `veiculos` VALUES (1,'ABC1234','1HGCM82633A123456','Ford','Fiesta',2010,2010,20000.00,25000.00,'Carro novo'),(2,'XYZ1234','1HGCM82633A123457','Toyota','Corolla',2020,2020,30000.00,35000.00,'Carro novo'),(3,'DEF5678','1HGCM82633A123458','Ford','Fiesta',2021,2021,35000.00,40000.00,'Carro novo'),(4,'GHI9101','1HGCM82633A123459','Chevrolet','Onix',2022,2022,30000.00,35000.00,'Carro novo'),(5,'JKL1121','1HGCM82633A123460','Hyundai','HB20',2020,2020,25000.00,30000.00,'Carro novo'),(6,'MNO1131','1HGCM82633A123461','Volkswagen','Golf',2019,2019,25000.00,30000.00,'Carro novo'),(7,'PQR1141','1HGCM82633A123462','Renault','Kwid',2021,2021,35000.00,40000.00,'Carro novo'),(8,'STU1151','1HGCM82633A123463','Fiat','Uno',2018,2018,20000.00,25000.00,'Carro novo'),(9,'VWX1161','1HGCM82633A123464','Peugeot','208',2020,2020,30000.00,35000.00,'Carro novo'),(10,'YZA1171','1HGCM82633A123465','Nissan','March',2019,2019,25000.00,30000.00,'Carro novo');
/*!40000 ALTER TABLE `veiculos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-13 11:44:40
