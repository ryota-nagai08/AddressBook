データベース設定

-- データベース作成
CREATE DATABASE IF NOT EXISTS dbaddress;
USE dbaddress;

-- テーブル作成
CREATE TABLE `d_contactinformation` (
    `contsctid` VARCHAR(8) NOT NULL,
    `fullname` VARCHAR(20) NULL DEFAULT NULL,
    `furigana` VARCHAR(20) NULL DEFAULT NULL,
    `companyname` VARCHAR(50) NULL DEFAULT NULL,
    `tel1_1` VARCHAR(4) NULL DEFAULT NULL,
    `tel1_2` VARCHAR(4) NULL DEFAULT NULL,
    `tel1_3` VARCHAR(4) NULL DEFAULT NULL,
    `tel2_1` VARCHAR(4) NULL DEFAULT NULL,
    `tel2_2` VARCHAR(4) NULL DEFAULT NULL,
    `tel2_3` VARCHAR(4) NULL DEFAULT NULL,
    `address` VARCHAR(255) NULL DEFAULT NULL,
    `birthday_year` INT(4) NULL DEFAULT NULL,
    `birthday_month` INT(2) NULL DEFAULT NULL,
    `birthday_day` INT(2) NULL DEFAULT NULL,
    `remarks` VARCHAR(255) NULL DEFAULT NULL,
    PRIMARY KEY (`contsctid`)
)
ENGINE=InnoDB
COLLATE='utf8mb4_0900_ai_ci';

-- データ挿入①
INSERT INTO `d_contactinformation` ( 
    `contsctid`,
    `fullname`,
    `furigana`,
    `companyname`,
    `tel1_1`,
    `tel1_2`,
    `tel1_3`,
    `tel2_1`,
    `tel2_2`,
    `tel2_3`,
    `address`,
    `birthday_year`,
    `birthday_month`,
    `birthday_day`,
    `remarks`
) VALUES (
    '01001NZC',
    'ナスカ　太郎',
    'ナスカ　タロウ',
    'NAZCA SYSTEM',
    '06',
    '6533',
    '7000',
    '090',
    '1111',
    '2222',
    '大阪市西区西本町1-15-6 西本町ビル10Ｆ',
    2000,
    8,
    8,
    '特になし'
);

-- データ挿入②
INSERT INTO `d_contactinformation` ( 
    `contsctid`,
    `fullname`,
    `furigana`,
    `companyname`,
    `tel1_1`,
    `tel1_2`,
    `tel1_3`,
    `tel2_1`,
    `tel2_2`,
    `tel2_3`,
    `address`,
    `birthday_year`,
    `birthday_month`,
    `birthday_day`,
    `remarks`
) VALUES (
    '01002NZC',
    'ナスカ　花子',
    'ナスカ　ハナコ',
    'NAZCA SYSTEM',
    '03',
    '5244',
    '4110',
    '090',
    '1010',
    '2020',
    '大阪市西区西本町1-15-6 西本町ビル10Ｆ',
    2015,
    10,
    5,
    '特になし'
);
