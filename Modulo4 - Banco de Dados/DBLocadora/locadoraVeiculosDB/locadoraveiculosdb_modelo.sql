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
  PRIMARY KEY (`Id`),
  KEY `FK_Modelo_Categoria` (`Categoria_Id`),
  KEY `FK_Modelo_Marca` (`Marca_Id`),
  CONSTRAINT `FK_Modelo_Categoria` FOREIGN KEY (`Categoria_Id`) REFERENCES `categoria` (`Id`),
  CONSTRAINT `FK_Modelo_Marca` FOREIGN KEY (`Marca_Id`) REFERENCES `marca` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=201 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modelo`
--

LOCK TABLES `modelo` WRITE;
/*!40000 ALTER TABLE `modelo` DISABLE KEYS */;
INSERT INTO `modelo` VALUES (1,'Toro',4,1),(2,'Strada',4,1),(3,'Argo',3,1),(4,'Cronos',2,1),(5,'Mobi',3,1),(6,'Pulse',1,1),(7,'Fastback',1,1),(8,'500e',3,1),(9,'Fiorino',8,1),(10,'Onix',3,2),(11,'Onix Plus',2,2),(12,'Tracker',1,2),(13,'S10',4,2),(14,'Montana',4,2),(15,'Spin',8,2),(16,'Cruze',2,2),(17,'Cruze Sport6',3,2),(18,'Equinox',1,2),(19,'Bolt EV',3,2),(20,'Polo',3,3),(21,'Virtus',2,3),(22,'T-Cross',1,3),(23,'Nivus',1,3),(24,'Amarok',4,3),(25,'Saveiro',4,3),(26,'Taos',1,3),(27,'Jetta GLI',2,3),(28,'ID.4',1,3),(29,'Ranger',4,4),(30,'Bronco Sport',1,4),(31,'Territory',1,4),(32,'Mustang Mach 1',5,4),(33,'Maverick',4,4),(34,'F-150',4,4),(35,'HB20',3,5),(36,'HB20S',2,5),(37,'Creta',1,5),(38,'Tucson',1,5),(39,'Kona',1,5),(40,'Corolla',2,6),(41,'Corolla Cross',1,6),(42,'Hilux',4,6),(43,'Yaris',3,6),(44,'Yaris Sedan',2,6),(45,'SW4',1,6),(46,'RAV4',1,6),(47,'Civic',2,7),(48,'HR-V',1,7),(49,'City',3,7),(50,'City Sedan',2,7),(51,'ZR-V',1,7),(52,'Kwid',3,8),(53,'Stepway',3,8),(54,'Logan',2,8),(55,'Duster',1,8),(56,'Oroch',4,8),(57,'Captur',1,8),(58,'Zoe E-Tech',3,8),(59,'Renegade',1,9),(60,'Compass',1,9),(61,'Commander',1,9),(62,'Gladiator',4,9),(63,'Wrangler',1,9),(64,'Kicks',1,10),(65,'Versa',2,10),(66,'Frontier',4,10),(67,'Leaf',3,10),(68,'208',3,12),(69,'2008',1,12),(70,'3008',1,12),(71,'e-2008',1,12),(72,'C3',3,13),(73,'C4 Cactus',1,13),(74,'C3 Aircross',1,13),(75,'L200 Triton',4,14),(76,'Eclipse Cross',1,14),(77,'Pajero Sport',1,14),(78,'Outlander',1,14),(79,'Tiggo 5X',1,11),(80,'Tiggo 7 Pro',1,11),(81,'Tiggo 8',1,11),(82,'Arrizo 6',2,11),(83,'iCar',3,11),(84,'Série 3',2,15),(85,'X1',1,15),(86,'X3',1,15),(87,'X5',1,15),(88,'Série 1',3,15),(89,'Z4',6,15),(90,'M3',2,15),(91,'iX',1,15),(92,'i4',5,15),(93,'Classe C',2,16),(94,'Classe A',3,16),(95,'GLA',1,16),(96,'GLC',1,16),(97,'GLE Coupé',5,16),(98,'AMG GT',5,16),(99,'EQS',2,16),(100,'Classe G',1,16),(101,'A3 Sedan',2,17),(102,'A3 Sportback',3,17),(103,'Q3',1,17),(104,'Q5',1,17),(105,'RS e-tron GT',5,17),(106,'RS6 Avant',7,17),(107,'TT RS',5,17),(108,'Q8',1,17),(109,'Defender',1,19),(110,'Discovery',1,19),(111,'Range Rover Evoque',1,19),(112,'Range Rover Velar',1,19),(113,'Range Rover Sport',1,19),(114,'XC40',1,20),(115,'XC60',1,20),(116,'XC90',1,20),(117,'S60',2,20),(118,'911 Carrera',5,21),(119,'718 Boxster',6,21),(120,'718 Cayman',5,21),(121,'Taycan',2,21),(122,'Panamera',2,21),(123,'Macan',1,21),(124,'Cayenne',1,21),(125,'UX',1,23),(126,'NX',1,23),(127,'ES',2,23),(128,'F-Pace',1,24),(129,'E-Pace',1,24),(130,'I-Pace',1,24),(131,'F-Type',5,24),(132,'Sportage',1,18),(133,'Stonic',1,18),(134,'Cerato',2,18),(135,'Niro',1,18),(136,'Carnival',8,18),(137,'Cooper S',3,25),(138,'Cooper Countryman',1,25),(139,'Cooper S Cabrio',6,25),(140,'1500',4,26),(141,'2500',4,26),(142,'3500',4,26),(143,'Rampage',4,26),(144,'Challenger',5,27),(145,'Charger',2,27),(146,'Durango',1,27),(147,'Forester',1,22),(148,'XV',9,22),(149,'Outback',7,22),(150,'Jimny',1,42),(151,'Jimny Sierra',1,42),(152,'Vitara',1,42),(153,'Dolphin',3,50),(154,'Yuan Plus',1,50),(155,'Seal',2,50),(156,'Tan',1,50),(157,'Han',2,50),(158,'Haval H6',1,51),(159,'Ora 03',3,51),(160,'Model 3',2,52),(161,'Model Y',1,52),(162,'Model S',2,52),(163,'Model X',1,52),(164,'E-JS1',3,46),(165,'T40',1,46),(166,'T60',1,46),(167,'296 GTB',5,29),(168,'SF90 Stradale',5,29),(169,'Roma',5,29),(170,'Purosangue',1,29),(171,'Urus',1,31),(172,'Huracán',5,31),(173,'Revuelto',5,31),(174,'720S',5,32),(175,'Artura',5,32),(176,'GT',5,32),(177,'A5 Sportback',5,17),(178,'X6',1,15),(179,'Classe E',2,16),(180,'Mustang GT',6,4),(181,'Polo Track',3,3),(182,'Tiggo 3x',1,11),(183,'C5 X',9,13),(184,'Kwid E-Tech',3,8),(185,'Compass 4xe',1,9),(186,'Corolla GR',2,6),(187,'Strada Ranch',4,1),(188,'Mobi Trekking',3,1),(189,'T-Cross Highline',1,3),(190,'Onix RS',3,2),(191,'HB20 Platinum',3,5),(192,'Creta N Line',1,5),(193,'Renegade Longitude',1,9),(194,'Kicks Exclusive',1,10),(195,'HR-V Touring',1,7),(196,'Civic Type R',3,7),(197,'Hilux SRX',4,6),(198,'Ranger Raptor',4,4),(199,'Taos Comfortline',1,3),(200,'S10 Z71',4,2);
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

-- Dump completed on 2025-09-16 21:49:28
