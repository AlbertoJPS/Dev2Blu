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
-- Table structure for table `pendencia`
--

DROP TABLE IF EXISTS `pendencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pendencia` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(225) DEFAULT NULL,
  `Descricao` text,
  `Custo` decimal(16,4) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pendencia`
--

LOCK TABLES `pendencia` WRITE;
/*!40000 ALTER TABLE `pendencia` DISABLE KEYS */;
INSERT INTO `pendencia` VALUES (1,'Atraso na Devolução','Custo aplicado por hora de atraso na devolução do veículo.',30.0000),(2,'Tanque Incompleto','Taxa de reabastecimento mais o valor do combustível faltante.',80.0000),(3,'Limpeza Especial','Custo para limpeza de estofados ou remoção de odores fortes (cigarro, etc).',120.0000),(4,'Arranhão Leve','Custo para reparo de pequenos arranhões na lataria.',250.0000),(5,'Avaria Grave','Custo referente à franquia do seguro para danos significativos.',1500.0000),(6,'Multa de Trânsito','Valor da multa de trânsito registrada durante o período de locação.',0.0000),(7,'Perda de Documento/Chave','Taxa administrativa pela perda da chave ou documento do veículo.',400.0000);
/*!40000 ALTER TABLE `pendencia` ENABLE KEYS */;
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
