DROP TABLE IF EXISTS LEVEL_UP_MOVE;
DROP TABLE IF EXISTS POKEMON;
DROP TABLE IF EXISTS TYPE_POKEMON;
DROP TABLE IF EXISTS ELEMENTARY_TYPE;
DROP TABLE IF EXISTS MOVEMENT_KIND;
DROP TABLE IF EXISTS MOVEMENT_RANGE;
CREATE TABLE ELEMENTARY_TYPE(
	ID_TYPE INT AUTO_INCREMENT,
    TYPE_NAME VARCHAR(100),
    RED_VALUE INT,
    GREEN_VALUE INT,
    BLUE_VALUE INT,
    PRIMARY KEY(ID_TYPE)
)ENGINE=INNODB;
CREATE TABLE MOVEMENT_RANGE(
	ID_MOVEMENT_RANGE INT AUTO_INCREMENT,
    MOVEMENT_RANGE VARCHAR(100),
    PRIMARY KEY(ID_MOVEMENT_RANGE)
)ENGINE=INNODB;
CREATE TABLE MOVEMENT_KIND(
	ID_MOVEMENT_KIND INT AUTO_INCREMENT,
    MOVEMENT_KIND VARCHAR(100),
    PRIMARY KEY(ID_MOVEMENT_KIND)
);
CREATE TABLE POKEMON(
	ID_POKEMON INT AUTO_INCREMENT,
    NATIONAL_POKEDEX_NUMBER VARCHAR(3),
    POKEMON_NAME VARCHAR(100),
    FID_TYPE_1 INT,
    FID_TYPE_2 INT NULL,
    HEIGHT DECIMAL(10,2),
    WEIGHT DECIMAL(10,2),
    DESCRIPTION VARCHAR(3000),
    PHOTO LONGBLOB,
    ACTIVE TINYINT,
    PRIMARY KEY(ID_POKEMON),
    FOREIGN KEY(FID_TYPE_1) REFERENCES ELEMENTARY_TYPE(ID_TYPE),
    FOREIGN KEY(FID_TYPE_2) REFERENCES ELEMENTARY_TYPE(ID_TYPE)
)ENGINE=INNODB;
CREATE TABLE LEVEL_UP_MOVE(
	ID_LEVEL_UP_MOVE INT AUTO_INCREMENT,
    FID_POKEMON INT,
    LEVEL_OF_LEARNING INT,
    NAME_MOVE VARCHAR(100),
    FID_TYPE INT,
    FID_KIND INT,
    POWER INT,
    ACCURACY INT,
    POWER_POINT INT,
    FID_RANGE INT,
    ACTIVE TINYINT,
    PRIMARY KEY(ID_LEVEL_UP_MOVE),
    FOREIGN KEY(FID_POKEMON) REFERENCES POKEMON(ID_POKEMON),
    FOREIGN KEY(FID_RANGE) REFERENCES MOVEMENT_RANGE(ID_MOVEMENT_RANGE),
    FOREIGN KEY(FID_TYPE) REFERENCES ELEMENTARY_TYPE(ID_TYPE),
    FOREIGN KEY(FID_KIND) REFERENCES MOVEMENT_KIND(ID_MOVEMENT_KIND)
)ENGINE=INNODB;
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('NORMAL',168,168,120);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('FIRE',240,128,48);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('FIGHTING',192,48,40);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('WATER',104,144,240);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('FLYING',168,144,240);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('GRASS',120,200,80);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('POISON',160,64,160);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('ELECTRIC',248,208,48);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('GROUND',224,192,104);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('PSYCHIC',248,88,136);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('ROCK',184,160,56);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('ICE',152,216,216);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('BUG',168,184,32);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('DRAGON',112,56,248);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('GHOST',112,88,152);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('DARK',112,88,72);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('STEEL',184,184,208);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('FAIRY',238,153,172);
INSERT INTO ELEMENTARY_TYPE(TYPE_NAME,RED_VALUE,GREEN_VALUE,BLUE_VALUE) VALUES('NONE',104,160,144);

INSERT INTO MOVEMENT_KIND(MOVEMENT_KIND) VALUES('PHYSICAL');
INSERT INTO MOVEMENT_KIND(MOVEMENT_KIND) VALUES('SPECIAL');
INSERT INTO MOVEMENT_KIND(MOVEMENT_KIND) VALUES('STATUS');

INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('1 ALLY');
INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('ADJACENT');
INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('BOTH SIDES');
INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('MANY OTHERS');
INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('NORMAL');
INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('OTHER SIDE');
INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('SELF');
INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('SELF, ALLY');
INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('VARIES');
INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('YOUR PARTY');
INSERT INTO MOVEMENT_RANGE(MOVEMENT_RANGE) VALUES('YOUR SIDE');

DELIMITER $
DROP PROCEDURE IF EXISTS QUERY_ALL_TYPES$
CREATE PROCEDURE QUERY_ALL_TYPES()
BEGIN
	SELECT ID_TYPE, TYPE_NAME, RED_VALUE, GREEN_VALUE, BLUE_VALUE FROM ELEMENTARY_TYPE ORDER BY TYPE_NAME ASC;
END$
DROP PROCEDURE IF EXISTS QUERY_ALL_RANGES$
CREATE PROCEDURE QUERY_ALL_RANGES()
BEGIN
	SELECT ID_MOVEMENT_RANGE, MOVEMENT_RANGE FROM MOVEMENT_RANGE ORDER BY MOVEMENT_RANGE ASC;
END$
DROP PROCEDURE IF EXISTS QUERY_ALL_KINDS$
CREATE PROCEDURE QUERY_ALL_KINDS()
BEGIN
	SELECT ID_MOVEMENT_KIND, MOVEMENT_KIND FROM MOVEMENT_KIND ORDER BY MOVEMENT_KIND ASC;
END$
DROP PROCEDURE IF EXISTS QUERY_ALL_POKEMON$
CREATE PROCEDURE QUERY_ALL_POKEMON(
	IN _NAME VARCHAR(100)
)
BEGIN
	SELECT P.ID_POKEMON, P.NATIONAL_POKEDEX_NUMBER, P.POKEMON_NAME, P.FID_TYPE_1, ET1.TYPE_NAME AS TYPE1_NAME, 
    ET1.RED_VALUE AS TYPE1RED, ET1.GREEN_VALUE AS TYPE1GREEN, ET1.BLUE_VALUE AS TYPE1BLUE,
    P.FID_TYPE_2, ET2.TYPE_NAME AS TYPE2_NAME, 
    ET2.RED_VALUE AS TYPE2RED, ET2.GREEN_VALUE AS TYPE2GREEN, ET2.BLUE_VALUE AS TYPE2BLUE,
    P.HEIGHT, P.WEIGHT, P.DESCRIPTION, P.PHOTO, P.ACTIVE
    FROM POKEMON P INNER JOIN ELEMENTARY_TYPE ET1 ON ET1.ID_TYPE = P.FID_TYPE_1
    INNER JOIN ELEMENTARY_TYPE ET2 ON ET2.ID_TYPE = P.FID_TYPE_2 WHERE P.POKEMON_NAME LIKE CONCAT('%',_NAME,'%') AND P.ACTIVE = 1 ORDER BY P.NATIONAL_POKEDEX_NUMBER ASC;
END$
DROP PROCEDURE IF EXISTS INSERT_POKEMON$
CREATE PROCEDURE INSERT_POKEMON(
	OUT _ID_POKEMON INT,
	IN _NATIONAL_POKEDEX_NUMBER VARCHAR(3),
    IN _FID_TYPE_1 INT,
    IN _FID_TYPE_2 INT,
    IN _POKEMON_NAME VARCHAR(100),
    IN _HEIGHT DECIMAL(10,2),
    IN _WEIGHT DECIMAL(10,2),
    IN _DESCRIPTION VARCHAR(3000),
    IN _PHOTO LONGBLOB
)
BEGIN
	INSERT INTO POKEMON(NATIONAL_POKEDEX_NUMBER,FID_TYPE_1,FID_TYPE_2,POKEMON_NAME,HEIGHT,WEIGHT,DESCRIPTION,PHOTO,ACTIVE) 
    VALUES(_NATIONAL_POKEDEX_NUMBER,_FID_TYPE_1,_FID_TYPE_2,_POKEMON_NAME,_HEIGHT,_WEIGHT,_DESCRIPTION,_PHOTO,1);
    SET _ID_POKEMON = last_insert_id();
END$
DROP PROCEDURE IF EXISTS INSERT_LVL_UP_MOVE$
CREATE PROCEDURE INSERT_LVL_UP_MOVE(
	IN _FID_POKEMON INT,
    IN _LEVEL_OF_LEARNING INT,
    IN _NAME_MOVE VARCHAR(100),
    IN _FID_TYPE INT,
    IN _FID_KIND INT,
    IN _POWER INT,
    IN _ACCURACY INT,
    IN _POWER_POINT INT,
    IN _FID_RANGE INT
)
BEGIN
	INSERT INTO LEVEL_UP_MOVE(FID_POKEMON,LEVEL_OF_LEARNING,NAME_MOVE,FID_TYPE,FID_KIND,POWER,ACCURACY,POWER_POINT,FID_RANGE,ACTIVE)
    VALUES(_FID_POKEMON,_LEVEL_OF_LEARNING,_NAME_MOVE,_FID_TYPE,_FID_KIND,_POWER,_ACCURACY,_POWER_POINT,_FID_RANGE,1);
END$
DROP PROCEDURE IF EXISTS QUERY_ALL_MOVES_BY_POKEMONID$
CREATE PROCEDURE QUERY_ALL_MOVES_BY_POKEMONID(
	IN _ID_POKEMON INT
)
BEGIN
	SELECT LM.ID_LEVEL_UP_MOVE, LM.FID_POKEMON, LM.LEVEL_OF_LEARNING, LM.NAME_MOVE, 
    LM.POWER, LM.ACCURACY, LM.POWER_POINT, LM.ACTIVE, LM.FID_TYPE, 
    ET.TYPE_NAME, ET.RED_VALUE, ET.GREEN_VALUE, ET.BLUE_VALUE, LM.FID_KIND,
    MK.MOVEMENT_KIND, LM.FID_RANGE, MR.MOVEMENT_RANGE, LM.ACTIVE
    FROM LEVEL_UP_MOVE LM 
    INNER JOIN ELEMENTARY_TYPE ET
    ON ET.ID_TYPE = LM.FID_TYPE
    INNER JOIN MOVEMENT_KIND MK
    ON MK.ID_MOVEMENT_KIND = LM.FID_KIND
    INNER JOIN MOVEMENT_RANGE MR
    ON MR.ID_MOVEMENT_RANGE = LM.FID_RANGE
    WHERE LM.FID_POKEMON = _ID_POKEMON AND LM.ACTIVE = 1
    ORDER BY LM.LEVEL_OF_LEARNING;
END$
DROP PROCEDURE IF EXISTS DELETE_POKEMON$
CREATE PROCEDURE DELETE_POKEMON(
	IN _ID_POKEMON INT
)
BEGIN
	UPDATE POKEMON SET ACTIVE = 0 WHERE ID_POKEMON = _ID_POKEMON;
END$
DROP PROCEDURE IF EXISTS UPDATE_POKEMON$
CREATE PROCEDURE UPDATE_POKEMON(
	IN _ID_POKEMON INT,
	IN _NATIONAL_POKEDEX_NUMBER VARCHAR(3),
    IN _FID_TYPE_1 INT,
    IN _FID_TYPE_2 INT,
    IN _POKEMON_NAME VARCHAR(100),
    IN _HEIGHT DECIMAL(10,2),
    IN _WEIGHT DECIMAL(10,2),
    IN _DESCRIPTION VARCHAR(3000),
    IN _PHOTO LONGBLOB
)
BEGIN
	UPDATE POKEMON SET 
		NATIONAL_POKEDEX_NUMBER = _NATIONAL_POKEDEX_NUMBER,
        FID_TYPE_1 = _FID_TYPE_1,
        FID_TYPE_2 = _FID_TYPE_2,
        POKEMON_NAME = _POKEMON_NAME,
        HEIGHT = _HEIGHT,
        WEIGHT = _WEIGHT,
        DESCRIPTION = _DESCRIPTION,
        PHOTO = _PHOTO
	WHERE ID_POKEMON = _ID_POKEMON;
END$
DROP PROCEDURE IF EXISTS DELETE_MOVES_BY_IDPOKEMON$
CREATE PROCEDURE DELETE_MOVES_BY_IDPOKEMON(
	IN _ID_POKEMON INT
)
BEGIN
	UPDATE LEVEL_UP_MOVE SET ACTIVE = 0 WHERE FID_POKEMON = _ID_POKEMON;
END$