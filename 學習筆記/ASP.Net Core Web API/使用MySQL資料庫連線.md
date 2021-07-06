步驟1->3參考網站：
https://stevenjhu.com/2020/09/06/c%E5%AD%B8%E7%BF%92asp-net-core-mvc-%E4%BD%BF%E7%94%A8mysql%E8%B3%87%E6%96%99%E5%BA%AB-%E4%BD%BF%E7%94%A8%E8%88%87%E7%AF%84%E6%9C%AC/

1.安裝以下套件：
 	Microsoft.EntityFrameworkCore.SqlServer
	Microsoft.EntityFrameworkCore.Tools
	MySql.Data
	MySql.EntityFrameworkCore
	Pomelo.EntityFrameworkCore.MySql
	
2.開啟套件管理器主況台：如果畫面上沒有就按：檢視->其他視窗->套件管理器主況台

3.到套件管理器主控台輸入以下指令：

Scaffold-DbContext "Server=伺服器ip;Database=資料庫名稱;User ID=帳號;Password=密碼" MySql.EntityFrameworkCore -OutputDir Models -Force

-OutputDir Models：產生的資料庫檔案在Models資料夾底下
-Force：如果有一樣的資料庫檔案就直接覆蓋

※如果執行失敗，請嘗試將Trusted_Connection=True改成false

步驟4->5參考網站：
https://talllkai.coderbridge.io/2021/04/13/DatabaseFirst/

4.執行成功後，在Models資料夾底下開啟 "資料庫名稱+Context.cs"，底下有一整串#warning的警告，將optionsBuilder.UseMySQL括號內包覆的連線字串複製，並依照以下格式貼到appsettings.json裡面，格式如下：

   "AllowedHosts": "*",=>在appsettings.json裡面原本就有，只是告知要貼上的相關位置

   "ConnectionStrings": { "連線字串名稱": "複製的連線字串" }
   
   做完上述步驟，要將一整串#warning的警告，連帶optionsBuilder.UseMySQL一整串都刪除
  
  5.打開Startup.cs，複製以下程式碼貼到
  public void ConfigureServices(IServiceCollection services)裡面：
  
  services.AddDbContext<資料庫名稱+Context>(options =>options.UseSqlServer(Configuration.GetConnectionString("連線字串名稱")));
