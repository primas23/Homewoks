## Database Systems - Overview
### _Homework_

####1. What database models do you know?

* *__Hierarchical (tree)__* where the data is organized into a tree-like structure, implying a single parent for each record.
* *__Network model__*  which expands upon the __hierarchical structure__, allowing many-to-many relationships in a tree-like structure that allows multiple parents.
* *__Relational model:__* The basic data structure of the relational model is the table, where information about a particular entity (say, an employee) is represented in rows (also called tuples) and columns. Thus, the "relation" in "relational database" refers to the various tables in the database; a relation is a set of tuples.
* *__Object-oriented:__* In the 1990s, the object-oriented programming paradigm was applied to database technology, creating a new database model known as object databases. This aims to avoid the object-relational impedance mismatch - the overhead of converting information between its representation in the database (for example as rows in tables) and its representation in the application program (typically as objects). Even further, the type system used in a particular application can be defined directly in the database, allowing the database to enforce the same data integrity invariants. Object databases also introduce the key ideas of object programming, such as encapsulation and polymorphism, into the world of databases.

####2. Which are the main functions performed by a Relational Database Management System (RDBMS)?

* It stores data in tables.
* Sharing a common column in two or more tables (primary and foreign key)
* Tables have rows and column. 
* These tables are created using SQL. 
* And data from these tables are also retrieved using SQL.
* Provides facility primary key to uniquely identify the rows.

####3. Define what is "table" in database terms.

* Database table A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows.

####4. Explain the difference between a primary and a foreign key.

* The __primary key__ consists of one or more columns whose data contained within is used to uniquely identify each row in the table.  You can think of the primary key as an address.  If the rows in a table were mailboxes, then the primary key would be the listing of street addresses.
* A __foreign key__ is a set of one or more columns in a table that refers to the primary key in another table.  There isn’t any special code, configurations, or table definitions you need to place to officially “designate” a foreign key.

####5. Explain the different kinds of relationships between tables in relational databases.

A relationship works by matching data in key columns — usually columns with the same name in both tables. In most cases, the relationship matches the primary key from one table, which provides a unique identifier for each row, with an entry in the foreign key in the other table. For example, book sales can be associated with the specific titles sold by creating a relationship between the title_id column in the titles table (the primary key) and the title_id column in the sales table (the foreign key).
* *__One-to-Many Relationship:__* A one-to-many relationship is the most common type of relationship. In this type of relationship, a row in table A can have many matching rows in table B, but a row in table B can have only one matching row in table A. For example, the publishers and titles tables have a one-to-many relationship: each publisher produces many titles, but each title comes from only one publisher.
* *__Many-to-Many Relationships:__* In a many-to-many relationship, a row in table A can have many matching rows in table B, and vice versa. You create such a relationship by defining a third table, called a junction table, whose primary key consists of the foreign keys from both table A and table B. For example, the authors table and the titles table have a many-to-many relationship that is defined by a one-to-many relationship from each of these tables to the titleauthors table. The primary key of the titleauthors table is the combination of the au_id column (the authors table's primary key) and the title_id column (the titles table's primary key).
* *__One-to-One Relationships:__* In a one-to-one relationship, a row in table A can have no more than one matching row in table B, and vice versa. A one-to-one relationship is created if both of the related columns are primary keys or have unique constraints.
This type of relationship is not common because most information related in this way would be all in one table. You might use a one-to-one relationship to:
  * Divide a table with many columns.
  * Isolate part of a table for security reasons.
  * Store data that is short-lived and could be easily deleted by simply deleting the table.
  * Store information that applies only to a subset of the main table.

####6. When is a certain database schema normalized?

  * What are the advantages of normalized databases?
  
####7. What are database integrity constraints and when are they used?

####8. Point out the pros and cons of using indexes in a database.

####9. What's the main purpose of the SQL language?

####10. What are transactions used for?
  * Give an example.
  
####11. What is a NoSQL database?

####12. Explain the classical non-relational data models.

####13. Give few examples of NoSQL databases and their pros and cons.
