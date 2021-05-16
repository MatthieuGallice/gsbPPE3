-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : mer. 05 mai 2021 à 11:41
-- Version du serveur :  5.7.24
-- Version de PHP : 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gsbppe3`
--

-- --------------------------------------------------------

--
-- Structure de la table `famille`
--

CREATE TABLE `famille` (
  `idFamille` int(3) NOT NULL,
  `libFamille` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `famille`
--

INSERT INTO `famille` (`idFamille`, `libFamille`) VALUES
(1, 'antihistaminique'),
(2, 'antidépresseur'),
(3, 'antibiotique'),
(4, 'Paracetamol');

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

CREATE TABLE `medecin` (
  `idMed` int(3) NOT NULL,
  `nomMed` varchar(45) DEFAULT NULL,
  `prenomMed` varchar(45) DEFAULT NULL,
  `adresseMed` varchar(256) DEFAULT NULL,
  `telMed` varchar(10) DEFAULT NULL,
  `idSpecialiteMed` int(3) NOT NULL,
  `departementMed` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `medecin`
--

INSERT INTO `medecin` (`idMed`, `nomMed`, `prenomMed`, `adresseMed`, `telMed`, `idSpecialiteMed`, `departementMed`) VALUES
(1, 'Dubois', 'Michel', '7 rue de la paix', '0728154859', 1, '58'),
(2, 'DelaMontagne', 'Augustin', '18 rue de la pierre', '0529384756', 2, '47'),
(3, 'LaForet', 'Charles', '596 avenue de la fontaine', '0328694753', 3, '58'),
(4, 'Martinier', 'Laurie', '64 rue de l\'apocalypse', '0508472906', 4, '47'),
(5, 'Partition ', 'Simon', '61 avenue de la musique', '0729381459', 5, '18');

-- --------------------------------------------------------

--
-- Structure de la table `medicament`
--

CREATE TABLE `medicament` (
  `idMedicament` int(3) NOT NULL,
  `nomCommercialMedicament` varchar(60) DEFAULT NULL,
  `idFamilleMedicament` int(3) NOT NULL,
  `compositionMedicament` varchar(256) DEFAULT NULL,
  `effetsMedicament` varchar(256) DEFAULT NULL,
  `contreIndicationsMedicament` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `medicament`
--

INSERT INTO `medicament` (`idMedicament`, `nomCommercialMedicament`, `idFamilleMedicament`, `compositionMedicament`, `effetsMedicament`, `contreIndicationsMedicament`) VALUES
(1, 'noHistami', 1, 'nécrose tumorale ', 'protéines spécialisées qui organisent la communication entre les cellules qui composent le système immunitaire', 'Trouble digestif'),
(2, 'noDepression', 2, 'lithium', 'Réduit la dépression', 'dysfonctionnements sexuels '),
(3, 'sansDepression', 2, 'composents', 'effets', 'contreIndications'),
(4, 'antibiobio', 3, 'substance naturelle ou synthétique ', 'cible ribosome bactérien ', 'Immunotoxicité'),
(5, 'sansHistami', 1, '500 mg de poudre de gingembre ', 'agit contre les vomissements et les nausées', 'événement indésirable médicamenteux '),
(6, 'Valdoxan', 2, 'paroxétine ', 'Réduit la dépression', 'risque de toxicité cardiovasculaire'),
(7, 'Antidepressant', 2, 'fluoxétine', 'Soigne la dépression, tranquillisant', 'risque de toxicité cardiovasculaire , décès à forte dose '),
(8, 'Antimatter', 1, 'paroxétine , fluoxétine', 'Réduit la dépression', 'Risque suicide, décès à forte dose'),
(9, 'Efferalgan', 4, 'Sorbitol , talc, copolymère oxyde de magnésium léger , carmellose sodique , dioxyde de titane , butanamide .', 'remède contre douleur et fièvre.', 'A forte dose risque de décès ou des conséquences très grave, Amnésie , Aplaisie , Œdème , Pancréatite , Hémorragie , vomissement éruption cutané.'),
(10, 'Dafalgan ', 4, 'Paracetamol 1 g ', 'Traitement symptomatique des douleurs d\'intensité légère à modérée et/ou des états fébriles. \r\n\r\n', 'Si les symptômes persistent, demandez l\'avis de votre médecin ou de votre pharmacien.'),
(11, 'Fervex', 4, '0,500 g de paracetamol , 0.200 g d\'acide ascorbique ( Vitamine C) , 0.025 g de maléate de phéniramine , Saccharose\r\n', 'dans le traitement au cours des rhumes, rhinites, rhinopharyngites et des états grippaux de l\'écoulement nasal clair et des larmoiements,des éternuements,des maux de tête et/ou fièvre.\r\n', 'en cas d\'hypersensibilité à l\'un des constituants,en cas d\'insuffisance hépatocellulaire,en cas de risque de glaucome par fermeture de l\'angle,en cas de risque de rétention urinaire liée à des troubles urétro-prostatiques,chez l\'enfant de moins de 15 ans. ');

-- --------------------------------------------------------

--
-- Structure de la table `offrir`
--

CREATE TABLE `offrir` (
  `idRapportOff` int(3) NOT NULL,
  `idMedicamentOff` int(3) NOT NULL,
  `quantiteOff` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `offrir`
--

INSERT INTO `offrir` (`idRapportOff`, `idMedicamentOff`, `quantiteOff`) VALUES
(2, 2, 2),
(3, 3, 3),
(4, 4, 5),
(5, 1, 10);

-- --------------------------------------------------------

--
-- Structure de la table `rapport`
--

CREATE TABLE `rapport` (
  `idRap` int(3) NOT NULL,
  `dateRap` date DEFAULT NULL,
  `motifRap` varchar(60) DEFAULT NULL,
  `bilanRap` varchar(60) DEFAULT NULL,
  `idVisiteurRap` int(3) NOT NULL,
  `idMedecinRap` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `rapport`
--

INSERT INTO `rapport` (`idRap`, `dateRap`, `motifRap`, `bilanRap`, `idVisiteurRap`, `idMedecinRap`) VALUES
(1, '2020-11-10', ' périodicité', 'rien d\'anormal', 1, 1),
(2, '2020-09-16', 'nouveautés ou actualisations', 'Deux échantillons laissé au laboratoire', 2, 4),
(3, '2020-08-19', 'Problèmes occasionnel ', 'précisions sur un médicament', 4, 5),
(4, '2020-06-17', 'nouveautés ou actualisations', 'Présentations sans succès, ne semble pas intéressé ', 5, 3),
(5, '2020-08-29', 'périodicité', 'rien d\'anormal', 2, 2),
(6, '2020-11-30', 'Vistite', 'Analyse des nouveaux medicaments', 6, 2),
(7, '2020-12-01', 'Problème Mecidament', 'Rien à signaler', 10, 3);

-- --------------------------------------------------------

--
-- Structure de la table `specialite`
--

CREATE TABLE `specialite` (
  `idSpec` int(3) NOT NULL,
  `libSpec` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `specialite`
--

INSERT INTO `specialite` (`idSpec`, `libSpec`) VALUES
(1, 'Généraliste'),
(2, 'Spécialiste'),
(3, 'Service Hospitalier'),
(4, 'Infirmier'),
(5, 'Pharmacien'),
(6, 'Généraliste'),
(7, 'Infirmier'),
(8, 'Pharmacien'),
(9, 'Infirmier'),
(10, 'Généraliste'),
(11, 'Pharmacien'),
(12, 'Service hospitalier'),
(13, 'Pharmacien');

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

CREATE TABLE `visiteur` (
  `idVis` int(3) NOT NULL,
  `nomVis` varchar(30) DEFAULT NULL,
  `prenomVis` varchar(30) DEFAULT NULL,
  `loginVis` varchar(60) DEFAULT NULL,
  `mdpVis` varchar(60) DEFAULT NULL,
  `adresseVis` varchar(256) DEFAULT NULL,
  `cpVis` int(5) DEFAULT NULL,
  `villeVis` varchar(30) DEFAULT NULL,
  `dateEmbaucheVis` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `visiteur`
--

INSERT INTO `visiteur` (`idVis`, `nomVis`, `prenomVis`, `loginVis`, `mdpVis`, `adresseVis`, `cpVis`, `villeVis`, `dateEmbaucheVis`) VALUES
(1, 'DuCailloux', 'Kevin', 'kCailloux', 'cailloux123', '7958 rue maréchal pétain', 58000, 'Nevers', '2020-06-10'),
(2, 'Poirier', 'Justine', 'jPoirier', 'poirier123', '16 avenue de la pénombre', 47000, 'Agen', '2020-05-14'),
(3, 'Narou', 'Laeticia', 'lNarou', 'narou123', '54 rue des marécages', 69000, 'Lyon', '2020-11-02'),
(4, 'Lebateau', 'Olivier', 'oLebateau', 'lebateau123', '18 avenue de la marinière', 18000, 'Bourges', '2020-09-17'),
(5, 'Renaut', 'Arthur', 'aRenaut', 'renaut123', '29 rue de patrick sebastien ', 58000, 'Nevers', '2020-10-28'),
(6, 'Potier', 'Samuel', 'Samu', 'samp02', '5 rue des mylos', 14000, 'Paris', '2021-02-20'),
(7, 'Van dam', 'Jean', 'Jeje', 'vanj51', '7 place de la République', 58000, 'Nevers', '2021-02-06'),
(8, 'Vihom', 'Isabelle', 'Isab', 'iss41ab', '7 place de la mairie', 78000, 'Orlean', '2021-01-05'),
(9, 'Huby', 'Laurence', 'Laur', 'lolo71', '15 Avenue des boulettes  ', 48000, 'Nantes', '2020-11-04'),
(10, 'Molette', 'Sabir', 'sab', 'sab410', '30 Avenue des vents ', 58000, 'Nevers', '2020-12-12'),
(11, 'Anod', 'Zemmour', 'Zem', 'zeze41', '9 Rue Michelet', 75006, 'Paris', '2021-01-20'),
(12, 'Maupas', 'Carine', 'Carinem', 'camcam21', '7 CHEM Henri IV', 65200, 'Gerde', '2020-11-20'),
(13, 'Polom', 'Armand', 'Arma', 'armandbg51', '55 Avenue Millies Lacroix', 59640, 'Dunkerque', '2021-01-14'),
(14, 'Poiret', 'Clément', 'clecle', 'clemclem51', '66 rue Ernest Renan', 52000, 'Chaumont', '2020-09-10'),
(15, 'Amero', 'Bruno', 'brunono', 'brubru41', '96 rue La Boétie', 75015, ' Paris', '2020-11-20');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `famille`
--
ALTER TABLE `famille`
  ADD PRIMARY KEY (`idFamille`);

--
-- Index pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD PRIMARY KEY (`idMed`),
  ADD KEY `FK_idSpecialiteMed` (`idSpecialiteMed`) USING BTREE;

--
-- Index pour la table `medicament`
--
ALTER TABLE `medicament`
  ADD PRIMARY KEY (`idMedicament`),
  ADD KEY `FK_idFamilleMedicament` (`idFamilleMedicament`) USING BTREE;

--
-- Index pour la table `offrir`
--
ALTER TABLE `offrir`
  ADD PRIMARY KEY (`idRapportOff`,`idMedicamentOff`),
  ADD KEY `FK_idRapportOff` (`idRapportOff`) USING BTREE,
  ADD KEY `FK_idMedicamentOff` (`idMedicamentOff`);

--
-- Index pour la table `rapport`
--
ALTER TABLE `rapport`
  ADD PRIMARY KEY (`idRap`),
  ADD KEY `FK_idVisiteurRap` (`idVisiteurRap`) USING BTREE,
  ADD KEY `FK_idMedecinRap` (`idMedecinRap`) USING BTREE;

--
-- Index pour la table `specialite`
--
ALTER TABLE `specialite`
  ADD PRIMARY KEY (`idSpec`);

--
-- Index pour la table `visiteur`
--
ALTER TABLE `visiteur`
  ADD PRIMARY KEY (`idVis`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `famille`
--
ALTER TABLE `famille`
  MODIFY `idFamille` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `medecin`
--
ALTER TABLE `medecin`
  MODIFY `idMed` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `medicament`
--
ALTER TABLE `medicament`
  MODIFY `idMedicament` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pour la table `rapport`
--
ALTER TABLE `rapport`
  MODIFY `idRap` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `specialite`
--
ALTER TABLE `specialite`
  MODIFY `idSpec` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT pour la table `visiteur`
--
ALTER TABLE `visiteur`
  MODIFY `idVis` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD CONSTRAINT `medecin_ibfk_1` FOREIGN KEY (`idSpecialiteMed`) REFERENCES `specialite` (`idSpec`);

--
-- Contraintes pour la table `medicament`
--
ALTER TABLE `medicament`
  ADD CONSTRAINT `FK_famille` FOREIGN KEY (`idFamilleMedicament`) REFERENCES `famille` (`idFamille`);

--
-- Contraintes pour la table `offrir`
--
ALTER TABLE `offrir`
  ADD CONSTRAINT `FK_idMedicamentOff` FOREIGN KEY (`idMedicamentOff`) REFERENCES `medicament` (`idMedicament`),
  ADD CONSTRAINT `FK_idRapportOff` FOREIGN KEY (`idRapportOff`) REFERENCES `rapport` (`idRap`);

--
-- Contraintes pour la table `rapport`
--
ALTER TABLE `rapport`
  ADD CONSTRAINT `FK_idMed` FOREIGN KEY (`idMedecinRap`) REFERENCES `medecin` (`idMed`),
  ADD CONSTRAINT `FK_idVis` FOREIGN KEY (`idVisiteurRap`) REFERENCES `visiteur` (`idVis`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
