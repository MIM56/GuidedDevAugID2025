 create or replace view pubic."UsrVwContactAgeDays" as
 select "Id" as "UsrId", "Name" as "UsrName", "BirthDate" as "UsrBirthDate", CURRENT-"BirthDate" as"UsrAgeDays"
 from public."Contact"