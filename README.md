# TestCoverletMergeWith

The "MergeWith" option doesn't seem to be working. When running coverlet againest test1:

`dotnet test Test1.csproj /p:CollectCoverage=true` 

it created a coverage.json and a report like this:

```
Total tests: 1. Passed: 1. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 1.0036 Seconds

Calculating coverage result...
  Generating report 'C:\TestCoverlet\Test1\Test1\coverage.json'

+---------+--------+--------+--------+
| Module  | Line   | Branch | Method |
+---------+--------+--------+--------+
| Module1 | 50%    | 100%   | 50%    |
+---------+--------+--------+--------+

+---------+--------+--------+--------+
|         | Line   | Branch | Method |
+---------+--------+--------+--------+
| Total   | 50%    | 100%   | 50%    |
+---------+--------+--------+--------+
| Average | 50%    | 100%   | 50%    |
+---------+--------+--------+--------+
```
Then I run test2 and merge with test1 json:
`dotnet test Test2.csproj /p:CollectCoverage=true /p:MergeWith='C:\TestCoverlet\Test1\Test1\coverage.json'`

output:

```
Total tests: 1. Passed: 1. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 0.9316 Seconds

Calculating coverage result...
  Generating report 'C:\TestCoverlet\Test2\coverage.json'

+---------+--------+--------+--------+
| Module  | Line   | Branch | Method |
+---------+--------+--------+--------+
| Module2 | 50%    | 100%   | 50%    |
+---------+--------+--------+--------+

+---------+--------+--------+--------+
|         | Line   | Branch | Method |
+---------+--------+--------+--------+
| Total   | 50%    | 100%   | 50%    |
+---------+--------+--------+--------+
| Average | 50%    | 100%   | 50%    |
+---------+--------+--------+--------+
```

It did not merge with the Tes1 Json which contains coverage for Module1.
