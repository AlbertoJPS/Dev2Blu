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
-- Table structure for table `reserva_servico`
--

DROP TABLE IF EXISTS `reserva_servico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reserva_servico` (
  `Reserva_Id` int NOT NULL,
  `Servico_Id` int NOT NULL,
  PRIMARY KEY (`Reserva_Id`,`Servico_Id`),
  KEY `Servico_Id` (`Servico_Id`),
  CONSTRAINT `reserva_servico_ibfk_1` FOREIGN KEY (`Reserva_Id`) REFERENCES `reserva` (`Id`),
  CONSTRAINT `reserva_servico_ibfk_2` FOREIGN KEY (`Servico_Id`) REFERENCES `servico` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reserva_servico`
--

LOCK TABLES `reserva_servico` WRITE;
/*!40000 ALTER TABLE `reserva_servico` DISABLE KEYS */;
INSERT INTO `reserva_servico` VALUES (2,1),(3,1),(6,1),(8,1),(9,1),(11,1),(13,1),(14,1),(15,1),(17,1),(18,1),(19,1),(20,1),(21,1),(23,1),(24,1),(26,1),(28,1),(29,1),(30,1),(31,1),(32,1),(33,1),(35,1),(36,1),(37,1),(38,1),(40,1),(41,1),(43,1),(44,1),(45,1),(46,1),(47,1),(49,1),(100,1),(103,1),(104,1),(107,1),(108,1),(109,1),(110,1),(111,1),(112,1),(113,1),(115,1),(116,1),(117,1),(118,1),(119,1),(121,1),(122,1),(123,1),(124,1),(125,1),(126,1),(128,1),(129,1),(130,1),(131,1),(133,1),(135,1),(136,1),(137,1),(138,1),(139,1),(140,1),(141,1),(144,1),(145,1),(146,1),(148,1),(149,1),(150,1),(151,1),(153,1),(154,1),(155,1),(156,1),(157,1),(158,1),(159,1),(160,1),(162,1),(163,1),(164,1),(165,1),(166,1),(168,1),(169,1),(170,1),(171,1),(172,1),(173,1),(174,1),(176,1),(177,1),(178,1),(179,1),(180,1),(181,1),(182,1),(183,1),(184,1),(185,1),(186,1),(187,1),(188,1),(189,1),(190,1),(191,1),(192,1),(193,1),(194,1),(195,1),(196,1),(197,1),(198,1),(199,1),(200,1),(4,2),(5,2),(10,2),(12,2),(16,2),(22,2),(25,2),(27,2),(34,2),(39,2),(42,2),(48,2),(50,2),(101,2),(102,2),(105,2),(106,2),(114,2),(120,2),(127,2),(132,2),(134,2),(142,2),(143,2),(147,2),(152,2),(167,2),(175,2),(1,3),(2,3),(4,3),(5,3),(7,3),(8,3),(10,3),(13,3),(14,3),(16,3),(20,3),(25,3),(29,3),(33,3),(34,3),(39,3),(48,3),(102,3),(106,3),(111,3),(114,3),(132,3),(136,3),(142,3),(147,3),(151,3),(152,3),(157,3),(167,3),(171,3),(175,3),(179,3),(186,3),(8,4),(10,4),(25,4),(48,4),(106,4),(132,4),(142,4),(152,4),(167,4),(10,5),(25,5),(48,5),(106,5),(132,5),(142,5),(152,5),(167,5),(5,6),(10,6),(16,6),(34,6),(39,6),(102,6),(114,6),(147,6),(175,6),(5,7),(16,7),(34,7),(39,7),(102,7),(114,7),(147,7),(175,7);
/*!40000 ALTER TABLE `reserva_servico` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-16 21:49:27
