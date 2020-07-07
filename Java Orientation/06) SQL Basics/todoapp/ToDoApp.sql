CREATE SCHEMA `todoapp`;

USE todoapp;

CREATE TABLE `todoapp`.`task` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(150) NULL,
  `status` VARCHAR(150) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE);
  
insert into task
(name, status)
values ("Homework", "pending");
insert into task
(name, status)
values ("Walk the Dog", "pending");
insert into task
(name, status)
values ("Buy milk", "pending");

UPDATE task
SET status = "complete"
WHERE id = 2;

SET SQL_SAFE_UPDATES = 0;

DELETE FROM task
WHERE status = "complete";

select * from task;