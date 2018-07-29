open Dapper
open MySql.Data.MySqlClient
open System
open System.ComponentModel.DataAnnotations.Schema

/// Using the same casing as on the bd on the constructor allows dapper to map the object properly.
type AccountInfo(name: string, phone_office: string) =
    member this.Name = name
    member this.PhoneOffice = phone_office

/// Needed until F# includes anonymous records.
/// https://github.com/fsharp/fslang-design/blob/master/RFCs/FS-1030-anonymous-records.md
type QueryParams = { deleted: int }

[<EntryPoint>]
let main argv =
    try
        let connString = Environment.GetEnvironmentVariable("ConnectionStrings:MysqlSugarCrm");
        let conn = new MySqlConnection(connString)

        // Do the query almost old school style.
        let sql = "SELECT name, phone_office FROM accounts WHERE deleted = @deleted ORDER BY name"        
        let accounts = conn.Query<AccountInfo>(sql, { deleted = 0 })

        // Print all the accounts found on the db.
        accounts
        |> Seq.iter(fun x -> printfn "%s\t%s" x.Name x.PhoneOffice)

    with
    | ex -> 
        printfn "%s" ex.Message
        printfn "%s" ex.StackTrace
            
    Console.ReadLine() |> ignore
    0 // return an integer exit code
