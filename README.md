# HelperMySql.Dapper
<p align="left">
  <br>
  <a href="https://github.com/raihanM95/MySql.Dapper.Helper">
    <img src="https://img.shields.io/github/languages/code-size/raihanM95/MySql.Dapper.Helper" alt="code-size">
  </a>
  <a>
    <img src="https://img.shields.io/github/languages/count/raihanM95/MySql.Dapper.Helper" alt="languages">
  </a>
  <a>
    <img src="https://img.shields.io/github/release/raihanM95/MySql.Dapper.Helper" alt="release">
  </a>
  <a href="https://github.com/raihanM95/MySql.Dapper.Helper/blob/main/LICENSE">
    <img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="licenses">
  </a>
</p>

## Objectives
A high performance Helper supporting MySQL.


## Instructions

+ **Installation**
    * Go to Solution » Manage NuGet Packages » Browse HelperMySql.Dapper
    * Install HelperMySql.Dapper
    
    <img src="documentations/documentation-1.png" alt="Screen"/>
    
+ **Use**
    * Insert
    * Query like "INSERT INTO credentials (email,password,createdBy,created) VALUES (@Email,@Password,@CreatedBy,@Created)"
    ```
    await GenericRepository<entityName>.AddAsync("ConnectionString", "query", entityName);
    ```
    
    * Select All
    * Query like "SELECT * FROM credentials"
    ```
    await GenericRepository<entityName>.GetAllAsync("ConnectionString", "query");
    ```
    
    * Select By Id
    * Query like "SELECT * FROM credentials WHERE id = @Id"
    ```
    await GenericRepository<entityName>.GetByIdAsync("ConnectionString", "query", id);
    ```
    
    * Update
    * Query like "UPDATE credentials SET email = @Email, password = @Password, lastModifiedBy = @LastModifiedBy, lastModified = @LastModified WHERE id = @Id"
    ```
    await GenericRepository<entityName>.UpdateAsync("ConnectionString", "query", entityName);
    ```
    
    * Delete
    * Query like "DELETE FROM credentials WHERE id = @Id"
    ```
    await GenericRepository<entityName>.DeleteAsync("ConnectionString", "query", id);
    ```
