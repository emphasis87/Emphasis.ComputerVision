@powershell -Command "ls -Path .\ -Include pack,bin,obj,.vs -Recurse -Force | %% { try { Write-Host $_; Remove-Item $_ -Force -Recurse -ErrorAction SilentlyContinue } catch { } }"
