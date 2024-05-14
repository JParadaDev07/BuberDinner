# BuberDinner API

- [Buber Dinner API](#buberdinner-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)


## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request 

```json
{
    "firstName" : "Julian",
    "lastName" : "Parada",
    "email" : "examplemail@mail.co",
    "password" : "JAPW123"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id" : "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
    "firstName" : "Julian",
    "lastName" : "Parada",
    "email" : "examplemail@mail.co",
    "token" : "eyjb..zsw2e41sd"

}
```

### Login
```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email" : "examplemail@mail.co",
    "password" : "JAPW123"
}
```

#### Login response
```js
200 OK
```

```json
{
    "id" : "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
    "firstName" : "Julian",
    "lastName" : "Parada",
    "email" : "examplemail@mail.com",
    "token" : "eyjhb...sddQ"

}
```







