# Repro Steps
- `cd ./appshell` and run `npm i` and then `npm run build`
- `cd ../SuperCoolApp.Ui` and run `dotnet build`
- `cd ../piral~/SuperCoolApp.Ui` and run `npm start`

#  Problem
- On the page `/hello` an error is shown in the browsers console, because `@inject CustomLogger<T> _customLogger` in `SuperCoolApp.Ui\Components\LoggingComponent.razor` can not be resolved.