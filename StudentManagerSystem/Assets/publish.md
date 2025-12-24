# dotnet publish 常用参数一览表

| 参数 | 含义 | 常见取值 / 说明 | 是否常用 |
|----|----|----|----|
| `dotnet publish` | 发布项目 | 将项目编译并生成可分发程序 | ⭐⭐⭐ |
| `-c Release` | 编译配置 | `Release` / `Debug`（发布必须用 Release） | ⭐⭐⭐ |
| `-r win-x64` | 运行平台 | `win-x64`、`win-x86`、`linux-x64`、`osx-x64`、`osx-arm64` | ⭐⭐⭐ |
| `--self-contained true` | 自包含发布 | 包含 .NET 运行时，目标机器无需安装 .NET | ⭐⭐⭐ |
| `--self-contained false` | 框架依赖 | 目标机器必须已安装 .NET | ⭐ |
| `/p:PublishSingleFile=true` | 单文件发布 | 所有依赖打包为一个 exe | ⭐⭐⭐ |
| `/p:IncludeNativeLibrariesForSelfExtract=true` | 原生库自解压 | 提高单文件兼容性（强烈推荐） | ⭐⭐⭐ |
| `-o ./dist` | 输出目录 | 指定发布结果存放路径 | ⭐⭐ |
| `/p:ApplicationIcon=icon.ico` | 程序图标 | 仅 Windows 有效 | ⭐⭐ |
| `/p:Version=1.0.0` | 版本号 | 设置程序集版本 | ⭐ |
| `/p:AssemblyName=AppName` | 程序名 | 指定生成 exe 名称 | ⭐ |
| `/p:DebugType=embedded` | 调试符号 | 一般发布不需要 | ⭐ |
| `/p:PublishTrimmed=true` | 裁剪程序集 | 减小体积（可能有兼容风险） | ⚠ |

---

## 推荐发布组合（Windows 单文件）

| 目标 | 参数组合 |
|----|----|
| 单 exe、无需 .NET | `-c Release -r win-x64 --self-contained true /p:PublishSingleFile=true` |
| 指定输出目录 | `-o ./dist` |
| 图标 + 稳定性 | `/p:ApplicationIcon=icon.ico /p:IncludeNativeLibrariesForSelfExtract=true` |

---

## 完整示例

dotnet publish -c Release -r win-x64 --self-contained true  
/p:PublishSingleFile=true  
/p:IncludeNativeLibrariesForSelfExtract=true  
/p:ApplicationIcon=icon.ico  
-o ./dist

---

## 发布结果说明

| 项目 | 说明 |
|----|----|
| 输出文件 | `dist/你的程序.exe` |
| 运行环境 | 任意 Windows 64 位 |
| 是否需要 .NET | ❌ 不需要 |
| 适合场景 | 直接拷贝、发给他人 |

