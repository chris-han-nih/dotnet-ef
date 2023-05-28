Programming Entity Framework
---
## Init
### Create new project
```bash
$ dotnet new sln -o dotnet-ef
$ dotnet new webapi -o break-away
$ dotnet sln dotnet-ef.sln add break-away/break-away.csproj
```

### Dependencies
```bash
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
```

### DB Migration
```bash
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
```
## 코드 퍼스트 처음으로 살펴보기
### 테이블, 스키마, 칼럽 이름의 규칙
> 테이블, 스키마, 칼럼 이름에 대한 코드 퍼스트의 테이블 명명 규칙은 영어 규칙에 따라 클래스 이름의 복수형을 결정하는 엔티티 프레임워크의 Pluralization 
> 서비스를 사용한다.
### 키 규칙
> 코드 퍼스트의 규칙은 Id 또는 [클래스 이름]Id라는 이름의 칼럼을 기본 키로 사용한다.
### 문자열 프로퍼티 규칙
> 문자열 규칙은 길에에 대한 제한 없이 null 허용 칼럼에 매핑한다는 것이다. SQL Server에서는 nvarchar(max)로 매핑된다.
### 설정에 따른 규칙 재정의하기
> 우리가 제공하는 모든 구성정보에는 엔티티 프레임워크가 해당 데이터를 실행할 때 사용하는 모델의 일부가 포함된다. 이 정보는 데이터베이스 스키마에 영향을 줄 뿐만 
> 아니라 DbContext에 내장된 유효성 검사 기능에도 이용된다.

