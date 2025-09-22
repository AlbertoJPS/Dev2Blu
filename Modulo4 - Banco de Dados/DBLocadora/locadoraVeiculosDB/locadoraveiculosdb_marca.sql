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
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` VALUES (1,'Fiat'),(2,'Chevrolet'),(3,'Volkswagen'),(4,'Ford'),(5,'Hyundai'),(6,'Toyota'),(7,'Honda'),(8,'Renault'),(9,'Jeep'),(10,'Nissan'),(11,'Caoa Chery'),(12,'Peugeot'),(13,'Citroën'),(14,'Mitsubishi'),(15,'BMW'),(16,'Mercedes-Benz'),(17,'Audi'),(18,'Kia'),(19,'Land Rover'),(20,'Volvo'),(21,'Porsche'),(22,'Subaru'),(23,'Lexus'),(24,'Jaguar'),(25,'Mini'),(26,'RAM'),(27,'Dodge'),(28,'Chrysler'),(29,'Ferrari'),(30,'Maserati'),(31,'Lamborghini'),(32,'McLaren'),(33,'Aston Martin'),(34,'Bentley'),(35,'Rolls-Royce'),(36,'GMC'),(37,'Cadillac'),(38,'Buick'),(39,'Acura'),(40,'Infiniti'),(41,'Genesis'),(42,'Suzuki'),(43,'Mazda'),(44,'Alfa Romeo'),(45,'SsangYong'),(46,'JAC'),(47,'Lifan'),(48,'Effa'),(49,'Shineray'),(50,'BYD'),(51,'GWM'),(52,'Tesla'),(53,'Rivian'),(54,'Lucid'),(55,'Polestar'),(56,'Fisker'),(57,'Iveco'),(58,'Scania'),(59,'MAN'),(60,'DAF'),(61,'Kenworth'),(62,'Peterbilt'),(63,'Freightliner'),(64,'International'),(65,'Mack'),(66,'Agrale'),(67,'Troller'),(68,'Engesa'),(69,'Puma'),(70,'Gurgel'),(71,'Koenigsegg'),(72,'Pagani'),(73,'Bugatti'),(74,'Rimac'),(75,'Lotus'),(76,'Caterham'),(77,'Morgan'),(78,'Abarth'),(79,'Cupra'),(80,'DS Automobiles'),(81,'Lancia'),(82,'Opel'),(83,'Vauxhall'),(84,'SEAT'),(85,'Skoda'),(86,'Smart'),(87,'Maybach'),(88,'Alpina'),(89,'Brabus'),(90,'RUF'),(91,'Hennessey'),(92,'Saleen'),(93,'Spyker'),(94,'Wiesmann'),(95,'Donkervoort'),(96,'KTM'),(97,'Ariel'),(98,'Radical'),(99,'BAC'),(100,'Zenvo');
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

-- Dump completed on 2025-09-16 21:49:29
