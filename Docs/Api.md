# Event Planner API

- [Event Planner API](#event-planner-api)
  - [Create Event](#create-event)
    - [Create Event Request](#create-event-request)
    - [Create Event Response](#create-event-response)
  - [Get Event](#get-event)
    - [Get Event Request](#get-event-request)
    - [Get Event Response](#get-event-response)
  - [Update Event](#update-event)
    - [Update Event Request](#update-event-request)
    - [Update Event Response](#update-event-response)
  - [Delete Event](#delete-event)
    - [Delete Event Request](#delete-event-request)
    - [Delete Event Response](#delete-event-response)
  - [AUTH](#auth)
    - [Register](#register)
    - [Register Request](#register-request)
    - [Register Response](#register-response)
    - [Login](#login)
    - [Login Request](#login-request)
    - [Login Response](#login-response)

## Create Event

### Create Event Request

```js
POST /Events
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Event..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Create Event Response

```js
201 Created
```

```yml
Location: {{host}}/Events/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Event..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Get Event

### Get Event Request

```js
GET /Events/{{id}}
```

### Get Event Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Event..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Update Event

### Update Event Request

```js
PUT /Events/{{id}}
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Event..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Update Event Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Events/{{id}}
```

## Delete Event

### Delete Event Request

```js
DELETE /Events/{{id}}
```

### Delete Event Response

```js
204 No Content
```
## AUTH
### Register

```js
POST {{host}}/auth/register
```

### Register Request

```js
{
    "firstName": "Burak",
    "lastName": "Yılmaz",
    "email": "burak@burak.com",
    "password": "123"
}
```

### Register Response
```js
200 OK
```
```js
{
    "id": "1fab4bac-ccf0-4ead-9f6f-6abd2380ee8f",
    "firstName": "burak",
    "lastName": "yilmaz",
    "email": "myEmail",
    "token": "token"
}
```

### Login

```js
POST {{host}}/auth/login
```

### Login Request

```js
{
    "email": "burak@burak.com",
    "password": "123"
}
```

### Login Response
```js
200 OK
```
```js
{
    "id": "1fab4bac-ccf0-4ead-9f6f-6abd2380ee8f",
    "firstName": "burak",
    "lastName": "yilmaz",
    "email": "myEmail",
    "token": "token"
}
```