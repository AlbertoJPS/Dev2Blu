-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: locadoraveiculosdb
-- ------------------------------------------------------
-- Server version	8.0.43

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
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `marca` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(225) DEFAULT NULL,
  `AtivoMarca` enum('True','False') NOT NULL DEFAULT 'True',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` VALUES (1,'Fiat','True'),(2,'Chevrolet','True'),(3,'Volkswagen','True'),(4,'Ford','True'),(5,'Hyundai','True'),(6,'Toyota','True'),(7,'Honda','True'),(8,'Renault','True'),(9,'Jeep','True'),(10,'Nissan','True'),(11,'Caoa Chery','True'),(12,'Peugeot','True'),(13,'Citroën','True'),(14,'Mitsubishi','True'),(15,'BMW','True'),(16,'Mercedes-Benz','True'),(17,'Audi','True'),(18,'Kia','True'),(19,'Land Rover','True'),(20,'Volvo','True'),(21,'Porsche','True'),(22,'Subaru','True'),(23,'Lexus','True'),(24,'Jaguar','True'),(25,'Mini','True'),(26,'RAM','True'),(27,'Dodge','True'),(28,'Chrysler','True'),(29,'Ferrari','True'),(30,'Maserati','True'),(31,'Lamborghini','True'),(32,'McLaren','True'),(33,'Aston Martin','True'),(34,'Bentley','True'),(35,'Rolls-Royce','True'),(36,'GMC','True'),(37,'Cadillac','True'),(38,'Buick','True'),(39,'Acura','True'),(40,'Infiniti','True'),(41,'Genesis','True'),(42,'Suzuki','True'),(43,'Mazda','True'),(44,'Alfa Romeo','True'),(45,'SsangYong','True'),(46,'JAC','True'),(47,'Lifan','True'),(48,'Effa','True'),(49,'Shineray','True'),(50,'BYD','True'),(51,'GWM','True'),(52,'Tesla','True'),(53,'Rivian','True'),(54,'Lucid','True'),(55,'Polestar','True'),(56,'Fisker','True'),(57,'Iveco','True'),(58,'Scania','True'),(59,'MAN','True'),(60,'DAF','True'),(61,'Kenworth','True'),(62,'Peterbilt','True'),(63,'Freightliner','True'),(64,'International','True'),(65,'Mack','True'),(66,'Agrale','True'),(67,'Troller','True'),(68,'Engesa','True'),(69,'Puma','True'),(70,'Gurgel','True'),(71,'Koenigsegg','True'),(72,'Pagani','True'),(73,'Bugatti','True'),(74,'Rimac','True'),(75,'Lotus','True'),(76,'Caterham','True'),(77,'Morgan','True'),(78,'Abarth','True'),(79,'Cupra','True'),(80,'DS Automobiles','True'),(81,'Lancia','True'),(82,'Opel','True'),(83,'Vauxhall','True'),(84,'SEAT','True'),(85,'Skoda','True'),(86,'Smart','True'),(87,'Maybach','True'),(88,'Alpina','True'),(89,'Brabus','True'),(90,'RUF','True'),(91,'Hennessey','True'),(92,'Saleen','True'),(93,'Spyker','True'),(94,'Wiesmann','True'),(95,'Donkervoort','True'),(96,'KTM','True'),(97,'Ariel','True'),(98,'Radical','True'),(99,'BAC','True'),(100,'Zenvo','True'),(101,'Levian Motors','True'),(102,'Boiano Motors','True');
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-29 16:50:40
