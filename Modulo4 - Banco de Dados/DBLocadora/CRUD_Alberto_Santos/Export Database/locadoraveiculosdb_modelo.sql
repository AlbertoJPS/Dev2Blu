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
-- Table structure for table `modelo`
--

DROP TABLE IF EXISTS `modelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modelo` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(225) DEFAULT NULL,
  `Categoria_Id` int DEFAULT NULL,
  `Marca_Id` int DEFAULT NULL,
  `AtivoModelo` enum('True','False') NOT NULL DEFAULT 'True',
  PRIMARY KEY (`Id`),
  KEY `FK_Modelo_Categoria` (`Categoria_Id`),
  KEY `FK_Modelo_Marca` (`Marca_Id`),
  CONSTRAINT `FK_Modelo_Categoria` FOREIGN KEY (`Categoria_Id`) REFERENCES `categoria` (`Id`),
  CONSTRAINT `FK_Modelo_Marca` FOREIGN KEY (`Marca_Id`) REFERENCES `marca` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=203 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modelo`
--

LOCK TABLES `modelo` WRITE;
/*!40000 ALTER TABLE `modelo` DISABLE KEYS */;
INSERT INTO `modelo` VALUES (1,'Toro',4,1,'True'),(2,'Strada',4,1,'True'),(3,'Argo',3,1,'True'),(4,'Cronos',2,1,'True'),(5,'Mobi',3,1,'True'),(6,'Pulse',1,1,'True'),(7,'Fastback',1,1,'True'),(8,'500e',3,1,'True'),(9,'Fiorino',8,1,'True'),(10,'Onix',3,2,'True'),(11,'Onix Plus',2,2,'True'),(12,'Tracker',1,2,'True'),(13,'S10',4,2,'True'),(14,'Montana',4,2,'True'),(15,'Spin',8,2,'True'),(16,'Cruze',2,2,'True'),(17,'Cruze Sport6',3,2,'True'),(18,'Equinox',1,2,'True'),(19,'Bolt EV',3,2,'True'),(20,'Polo',3,3,'True'),(21,'Virtus',2,3,'True'),(22,'T-Cross',1,3,'True'),(23,'Nivus',1,3,'True'),(24,'Amarok',4,3,'True'),(25,'Saveiro',4,3,'True'),(26,'Taos',1,3,'True'),(27,'Jetta GLI',2,3,'True'),(28,'ID.4',1,3,'True'),(29,'Ranger',4,4,'True'),(30,'Bronco Sport',1,4,'True'),(31,'Territory',1,4,'True'),(32,'Mustang Mach 1',5,4,'True'),(33,'Maverick',4,4,'True'),(34,'F-150',4,4,'True'),(35,'HB20',3,5,'True'),(36,'HB20S',2,5,'True'),(37,'Creta',1,5,'True'),(38,'Tucson',1,5,'True'),(39,'Kona',1,5,'True'),(40,'Corolla',2,6,'True'),(41,'Corolla Cross',1,6,'True'),(42,'Hilux',4,6,'True'),(43,'Yaris',3,6,'True'),(44,'Yaris Sedan',2,6,'True'),(45,'SW4',1,6,'True'),(46,'RAV4',1,6,'True'),(47,'Civic',2,7,'True'),(48,'HR-V',1,7,'True'),(49,'City',3,7,'True'),(50,'City Sedan',2,7,'True'),(51,'ZR-V',1,7,'True'),(52,'Kwid',3,8,'True'),(53,'Stepway',3,8,'True'),(54,'Logan',2,8,'True'),(55,'Duster',1,8,'True'),(56,'Oroch',4,8,'True'),(57,'Captur',1,8,'True'),(58,'Zoe E-Tech',3,8,'True'),(59,'Renegade',1,9,'True'),(60,'Compass',1,9,'True'),(61,'Commander',1,9,'True'),(62,'Gladiator',4,9,'True'),(63,'Wrangler',1,9,'True'),(64,'Kicks',1,10,'True'),(65,'Versa',2,10,'True'),(66,'Frontier',4,10,'True'),(67,'Leaf',3,10,'True'),(68,'208',3,12,'True'),(69,'2008',1,12,'True'),(70,'3008',1,12,'True'),(71,'e-2008',1,12,'True'),(72,'C3',3,13,'True'),(73,'C4 Cactus',1,13,'True'),(74,'C3 Aircross',1,13,'True'),(75,'L200 Triton',4,14,'True'),(76,'Eclipse Cross',1,14,'True'),(77,'Pajero Sport',1,14,'True'),(78,'Outlander',1,14,'True'),(79,'Tiggo 5X',1,11,'True'),(80,'Tiggo 7 Pro',1,11,'True'),(81,'Tiggo 8',1,11,'True'),(82,'Arrizo 6',2,11,'True'),(83,'iCar',3,11,'True'),(84,'Série 3',2,15,'True'),(85,'X1',1,15,'True'),(86,'X3',1,15,'True'),(87,'X5',1,15,'True'),(88,'Série 1',3,15,'True'),(89,'Z4',6,15,'True'),(90,'M3',2,15,'True'),(91,'iX',1,15,'True'),(92,'i4',5,15,'True'),(93,'Classe C',2,16,'True'),(94,'Classe A',3,16,'True'),(95,'GLA',1,16,'True'),(96,'GLC',1,16,'True'),(97,'GLE Coupé',5,16,'True'),(98,'AMG GT',5,16,'True'),(99,'EQS',2,16,'True'),(100,'Classe G',1,16,'True'),(101,'A3 Sedan',2,17,'True'),(102,'A3 Sportback',3,17,'True'),(103,'Q3',1,17,'True'),(104,'Q5',1,17,'True'),(105,'RS e-tron GT',5,17,'True'),(106,'RS6 Avant',7,17,'True'),(107,'TT RS',5,17,'True'),(108,'Q8',1,17,'True'),(109,'Defender',1,19,'True'),(110,'Discovery',1,19,'True'),(111,'Range Rover Evoque',1,19,'True'),(112,'Range Rover Velar',1,19,'True'),(113,'Range Rover Sport',1,19,'True'),(114,'XC40',1,20,'True'),(115,'XC60',1,20,'True'),(116,'XC90',1,20,'True'),(117,'S60',2,20,'True'),(118,'911 Carrera',5,21,'True'),(119,'718 Boxster',6,21,'True'),(120,'718 Cayman',5,21,'True'),(121,'Taycan',2,21,'True'),(122,'Panamera',2,21,'True'),(123,'Macan',1,21,'True'),(124,'Cayenne',1,21,'True'),(125,'UX',1,23,'True'),(126,'NX',1,23,'True'),(127,'ES',2,23,'True'),(128,'F-Pace',1,24,'True'),(129,'E-Pace',1,24,'True'),(130,'I-Pace',1,24,'True'),(131,'F-Type',5,24,'True'),(132,'Sportage',1,18,'True'),(133,'Stonic',1,18,'True'),(134,'Cerato',2,18,'True'),(135,'Niro',1,18,'True'),(136,'Carnival',8,18,'True'),(137,'Cooper S',3,25,'True'),(138,'Cooper Countryman',1,25,'True'),(139,'Cooper S Cabrio',6,25,'True'),(140,'1500',4,26,'True'),(141,'2500',4,26,'True'),(142,'3500',4,26,'True'),(143,'Rampage',4,26,'True'),(144,'Challenger',5,27,'True'),(145,'Charger',2,27,'True'),(146,'Durango',1,27,'True'),(147,'Forester',1,22,'True'),(148,'XV',9,22,'True'),(149,'Outback',7,22,'True'),(150,'Jimny',1,42,'True'),(151,'Jimny Sierra',1,42,'True'),(152,'Vitara',1,42,'True'),(153,'Dolphin',3,50,'True'),(154,'Yuan Plus',1,50,'True'),(155,'Seal',2,50,'True'),(156,'Tan',1,50,'True'),(157,'Han',2,50,'True'),(158,'Haval H6',1,51,'True'),(159,'Ora 03',3,51,'True'),(160,'Model 3',2,52,'True'),(161,'Model Y',1,52,'True'),(162,'Model S',2,52,'True'),(163,'Model X',1,52,'True'),(164,'E-JS1',3,46,'True'),(165,'T40',1,46,'True'),(166,'T60',1,46,'True'),(167,'296 GTB',5,29,'True'),(168,'SF90 Stradale',5,29,'True'),(169,'Roma',5,29,'True'),(170,'Purosangue',1,29,'True'),(171,'Urus',1,31,'True'),(172,'Huracán',5,31,'True'),(173,'Revuelto',5,31,'True'),(174,'720S',5,32,'True'),(175,'Artura',5,32,'True'),(176,'GT',5,32,'True'),(177,'A5 Sportback',5,17,'True'),(178,'X6',1,15,'True'),(179,'Classe E',2,16,'True'),(180,'Mustang GT',6,4,'True'),(181,'Polo Track',3,3,'True'),(182,'Tiggo 3x',1,11,'True'),(183,'C5 X',9,13,'True'),(184,'Kwid E-Tech',3,8,'True'),(185,'Compass 4xe',1,9,'True'),(186,'Corolla GR',2,6,'True'),(187,'Strada Ranch',4,1,'True'),(188,'Mobi Trekking',3,1,'True'),(189,'T-Cross Highline',1,3,'True'),(190,'Onix RS',3,2,'True'),(191,'HB20 Platinum',3,5,'True'),(192,'Creta N Line',1,5,'True'),(193,'Renegade Longitude',1,9,'True'),(194,'Kicks Exclusive',1,10,'True'),(195,'HR-V Touring',1,7,'True'),(196,'Civic Type R',3,7,'True'),(197,'Hilux SRX',4,6,'True'),(198,'Ranger Raptor',4,4,'True'),(199,'Taos Comfortline',1,3,'True'),(200,'S10 Z71',4,2,'True'),(201,'Happy Bird 2.0',10,101,'True'),(202,'Jet Car RTX1080',12,102,'True');
/*!40000 ALTER TABLE `modelo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-29 16:50:42
