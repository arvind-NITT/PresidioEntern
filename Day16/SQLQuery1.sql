use EmployeeTracker

select * from EmployeeSkill

select * from Employees

--Update 
update Employees set phone = '9876543210'
where id = 101
update Employees set phone = '9988776655'
where id = 105


Insert into EmployeeSkill values(105,2,7)
Insert into EmployeeSkill values(105,3,7)

update EmployeeSkill set skillLevel = 8
where skill = 2 and Employee_id = 101

update EmployeeSkill set skillLevel =
case 
when skillLevel = 7 then 5
when skillLevel = 8 then 9
else skillLevel
end
where Employee_id = 101;

delete from Employees where id = 103;


select * FROM Areas;

