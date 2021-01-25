﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wyklad6_nauka.Services;

namespace Wyklad6_nauka.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string logsFile = "requestsLog.txt";

        public LoggingMiddleware(RequestDelegate next) {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IFileService fileService) {
            context.Request.EnableBuffering();
            if (context.Request != null)
            {
                string path = context.Request.Path;
                string method = context.Request.Method;
                string queryString = context.Request.QueryString.ToString();
                string bodyStrnig;

                using (var reader = new StreamReader(context.Request.Body, Encoding.UTF8, true, 1024, true))
                {
                    bodyStrnig = await reader.ReadToEndAsync();
                    context.Request.Body.Position = 0;
                }

                // zapisać do pliku
                using (var writer = new StreamWriter(logsFile, true))
                {
                    writer.WriteLine($"path: {path}, mathod: {method}, queryString: {queryString}, bodyString: {bodyStrnig}");
                }
            }

            await _next(context);
        }
    }
}
