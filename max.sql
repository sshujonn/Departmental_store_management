SELECT first_name, max(salary) 
from tbl_login,tbl_salary 
where  tbl_login.address=tbl_salary.address 
group by tbl_login.first_name