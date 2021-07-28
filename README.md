# Literal numbers

This is a Web API build in .NET Framework 4.7.2

It has Swagger for documentation: https://localhost:44306/swagger


There are three methods called: 
* IntToLocationNum: https://localhost:44306/api/IntToLocationNum
* LocationNumeralToInt: https://localhost:44306/api/LocationNumeralToInt
* LocationNumeralToAbreviated: https://localhost:44306/api/LocationNumeralToAbreviated

Each methods uses an input, these inputs has Data Annotations to make them required and handle Regular Expresions.

There is only one standard output that has three properties:
* Output: The result of the method itself (String).
* Message: In case of an exception or an known problem, there will appear a message.
* Result: It is an Enum that has only two values (Success and Error).


```
For method IntToLocationNum, the body request is:

{
  "input": 0
}

For LocationNumeralToInt and LocationNumeralToAbreviated methods, the body request is:

{
  "input": "string"
}

The output response is:

{
  "output": "string",
  "message": "string",
  "result": "success"
}

```