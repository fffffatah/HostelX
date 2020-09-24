create table Admins
(
    AdminId           int identity
        constraint PK_Admins
            primary key,
    AdminFirstName    varchar(50)  not null,
    AdminLastName     varchar(50)  not null,
    AdminPhone        varchar(50)  not null,
    AdminEmail        varchar(50)  not null,
    AdminPass         varchar(50)  not null,
    AdminProfileImage varchar(max) not null
)
go

create table Foods
(
    FoodId       int identity
        constraint PK_Foods
            primary key,
    FoodItem     varchar(50) not null,
    FoodQuantity int         not null,
    AdminId      int         not null
        constraint FK_Foods_Admins
            references Admins
            on delete cascade,
    FoodPrice    varchar(50)
)
go

create table Hostels
(
    HostelId       int identity
        constraint PK_Hostels
            primary key,
    HostelName     varchar(50)  not null,
    HostelAddress  varchar(max) not null,
    HostelType     varchar(50)  not null,
    HostelCapacity varchar(50)  not null,
    AdminId        int          not null
        constraint FK_Hostels_Admins
            references Admins
            on delete cascade
)
go

create table Notices
(
    Notice   nvarchar(max) not null,
    Date     varchar(50)   not null,
    HostelId int           not null
        constraint FK_Notices_Hostels
            references Hostels
            on delete cascade,
    NoticeId int identity
        constraint Notices_pk
            primary key nonclustered
)
go

create table Tenants
(
    TenantId           int identity
        constraint PK_Tenants
            primary key,
    TenantFirstName    varchar(50)  not null,
    TenantLastName     varchar(50)  not null,
    TenantPhone        varchar(50)  not null,
    TenantEmail        varchar(50)  not null,
    TenantAddress      varchar(max) not null,
    TenantInstitution  varchar(max) not null,
    TenantPass         varchar(50)  not null,
    TenantProfileImage varchar(max) not null,
    HostelId           int          not null
        constraint FK_Tenants_Hostels
            references Hostels
            on delete cascade,
    TenantGender       varchar(50)  not null
)
go

create table Payments
(
    PaymentId      int identity
        constraint PK_Payments
            primary key,
    Due            varchar(50) not null,
    Paid           varchar(50) not null,
    TenantId       int         not null
        constraint FK_Payments_Tenants
            references Tenants
            on delete cascade,
    Balance        varchar(50),
    PaymentDate    varchar(50),
    PaymentDueDate varchar(50)
)
go


