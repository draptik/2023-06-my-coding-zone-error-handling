# My Coding Zone Session 2023

## Abstract: Strategien für den Umgang mit Fehlern

Eine effiziente Fehlerbehandlung ist ein entscheidender Aspekt bei der Softwareentwicklung, der die Zuverlässigkeit und Wartbarkeit von Softwareprodukten beeinflusst.
In dieser Session möchte ich euch ein paar bewährte Strategien zeigen, die den Umgang mit Fehlern erleichtern. 

Zudem werden wir uns Programmierparadigmen anschauen, die uns helfen, effektive und sichere Code-Strukturen zu schaffen, die sowohl lesbar als auch wartbar sind. Es geht darum, wie wir durch geschickte Datenmodellierung und die Nutzung spezieller Datenstrukturen die Robustheit unserer Anwendungen signifikant steigern können.

Auch wenn die Codebeispiele in .NET (C# und F#) sein werden: Die zugrundeliegenden Konzepte sind unabhängig von der Programmiersprache und können in vielen anderen Sprache angewendet werden.

## Themensammlung

- Primitive Obsession vermeiden
  - Typsystem nutzen (Klassen, records, enums, ...)
  - Value Objects
- Null vermeiden
  - Nullability
  - Null Object Pattern
  - Optionals/Maybe
- Exceptions
  - Exceptions sind "echte" Probleme
  - Exceptions sind "unerwartete" Probleme
  - Exceptions sind "unvorhersehbar"
- Workflow sollte Happy Path zeigen, 
  - und nicht von Kontrollfluss unterbrochen werden. Beispiel für Unterbrechung des Kontrollflusses: 
    - Exceptions, 
    - Try/Catch, 
    - If/Else, ... 
  - Railway-Oriented Programming
  - C# FP Libraries
    - LanguageExt
    - CSharpFunctionalExtensions
    - LaYumba
- Einführung in F#
  - Immutable
  - Pattern Matching
  - Records
  - Optionals/Maybe
  - Railway-Oriented Programming
  - FsToolkit.ErrorHandling

## Fragen ans Publikum

- Mit welchen Sprachen arbeitet ihr?
