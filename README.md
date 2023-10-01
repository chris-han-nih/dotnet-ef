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
```bash:qa
$ dotnet tool install --global dotnet-ef
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
> 문자열 규칙은 길에에 대한 제한 없이 빈문자열을 기본값으로 하는칼럼에 매핑한다는 것이다. SQL Server에서는 nvarchar(max)로 매핑된다.
> MinLength Annotation은 엔티티 프레임워크의 유효성 검사에만 사용된다. 데이터베이스에는 영향을 주지 않는다.
### 설정에 따른 규칙 재정의하기
> 우리가 제공하는 모든 구성정보에는 엔티티 프레임워크가 해당 데이터를 실행할 때 사용하는 모델의 일부가 포함된다. 이 정보는 데이터베이스 스키마에 영향을 줄 뿐만 
> 아니라 DbContext에 내장된 유효성 검사 기능에도 이용된다.
---
## 코드 퍼스트로 프로퍼티 어트리뷰트 작업하기
### 길이
.|.
---|---
규칙|max (데이터베이스에 의해 지정된 타입)
Data Annotations|MinLength(nn)<br />MaxLength(nn)<br />Stringlength(nn)
Fluent API|Entity<T>.Property(t => t.Propert).HasMaxLength(nn)

### 데이터 타입
.|.
---|---
규칙|기본 칼럼 데이터 형식은 사용하고 있는 데이터베이스 공급자에 의해 결정된다. 다음은 SQL 서버의 몇 가지 기본 데이터 타입이다.<br />String: nvarchar(max)<br />Integer: int<br />Byte Array: varbinary(max)<br />Boolean: bit
Data Annotations|Column(TypeName="xxx")
Fluent API|Entity<T>.Property(t => t.Propert).HasColumnType("xxx")

### NULL 허용 및 Required 구성
.|.
---|---
규칙|키 프로퍼티: 데이터베이스에서 null이 아닌 타입<br />참조 타입(String, arrays): 데이터베이스에서 null이 될 수 있는 타입<br />값 타입(모든 숫자 타입, DateTime, bool, char): 데이터베이스에서 null이 아닌 타입<br />Nullable<T> Value Types: 데이터베이스에서 null이 될 수 있는 타입
Data Annotations|Required
Fluent API|Entity<T>.Property(t => t.PropertyName).IsRequired()

### 매핑 키
.|.
---|---
규칙|Id로 지정된 프로퍼티<br />[TypeName] + Id로 지정된 프로퍼티
Data Annotations|Key
Fluent API|Entity<T>.HasKey(t => t.PropertyName)

Entity Framework는 모든 엔티티가 키를 가질 것을 요구한다. 이 키는 개별 개체를 추적하는 컨텍스트에서 사용된다. 키는 데이터베이스에 의해 대체적으로 고유하게 생성된다.
모든 타입이 기본 키 프로퍼티로 사용될 수 있다 해도 가장 일반적으로 데이터베이스의 기본 키로 사용하는 타입은 int또는 GUID이다.<br />
`builder.Property(t => t.Id).ValueGeneratedNever();`설정을 추가하면 데이터베이스에서 기본 키를 생성하지 않는다.

### 낙관적 동시성에 대해 TimeStamp와 RowVersion 필드 구성하기
.|.
---|---
규칙|없음
Data Annotations|Timestamp
Fluent API|Entity<T>.Property(t => t.PropertyName).IsRowVersion()

### 십진법의 정밀과 스케일에 영향 주기
.|.
---|---
규칙|Decimal은 18, 2이다
Data Annotations|[Column(TypeName="decimal(8,2)")]
Fluent API|Entity<T>.Property(t => t.PropertyName).HasPrecision(18, 2)

### 코드 퍼스트에서 복합 타입으로 작업하기
.|.
---|---
규칙|없음
Data Annotations|ComplexType
Fluent API|Entity<T>.OwnsOne(t => t.PropertyName)

복합 타입은 **갑 타입**으로 알려져 있으며 다른 클래스에 부가적으로 프로퍼티를 추가하는 데 사용할 수 있다. 복합 타입을
엔티티 타입과 구별한다는 의미는 복합 타입에게 자신의 키가 없다는 것을 말한다. 이 방식은 변경 추적 및 지속을 위한
'호스트' 타입에 의존한다.
키 프로퍼티가 없고 하나 이상의 타입으로 매핑되는 프로퍼티를 사용하는 타입은 코드 퍼스트의 규칙에 의해 복합 타입으로 인식될 것이다.
코드 퍼스트는 복합 타입의 프로퍼티가 호스트 타입으로 매핑하는 테이블에 포함된다고 추정할 것이다.
