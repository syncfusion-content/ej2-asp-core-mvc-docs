---
layout: post
title: Amazon S3 Provider Docker Support in ##Platform_Name## File Manager | Syncfusion
description: Learn how to deploy the ##Platform_Name## File Manager Amazon S3 file provider using the pre-built Docker image and required Amazon S3 settings.
control: File Manager
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Amazon S3 Provider Docker Support in ##Platform_Name## File Manager

The ##Platform_Name## File Manager is a component for managing files and folders in a web application. It provides a Windows Explorer-like interface for file operations such as viewing, selecting, uploading, downloading, sorting, filtering, creating, renaming, copying, moving, and deleting files and folders.

This Docker image provides a preconfigured Docker container for the Syncfusion File Manager Amazon S3 file provider backend. The server-side Web API targets ASP.NET Core 10.0 and connects to Amazon S3 Storage.

You can quickly deploy the Docker image to your infrastructure. To add custom functionality, create your own Docker file based on the existing [File Manager Amazon S3 Docker project](https://github.com/SyncfusionExamples/amazon-s3-aspcore-file-provider).

## Prerequisites

Have Docker installed in your environment:

- On Windows, install [Docker for Windows](https://docs.docker.com/docker-for-windows/install/).
- On macOS, install [Docker for Mac](https://docs.docker.com/docker-for-mac/install/).

## How to deploy the File Manager Amazon S3 Service Docker Image

### Step 1: Pull the Amazon S3 file provider image from Docker Hub

{% tabs %}
{% highlight bash %}
docker pull syncfusion/filemanager-amazon-s3-aspnetcore-provider
{% endhighlight %}
{% endtabs %}

### Step 2: Create the docker-compose.yml file with the following content

{% tabs %}
{% highlight yaml tabtitle="docker-compose.yml" %}
version: '3.8'

services:
  amazon-s3-aspnetcore-provider:
    image: syncfusion/filemanager-amazon-s3-aspnetcore-provider:latest
    environment:
      # Provide your Amazon S3 credentials
      AWS_ACCESS_KEY_ID: YOUR_AWS_ACCESS_KEY_ID
      AWS_SECRET_ACCESS_KEY: YOUR_AWS_SECRET_ACCESS_KEY
      AWS_BUCKET_NAME: YOUR_AWS_BUCKET_NAME
      AWS_BUCKET_REGION: YOUR_AWS_BUCKET_REGION
    ports:
      - "5000:80"
{% endhighlight %}
{% endtabs %}

#### Amazon S3 credential details

| Environment Variable | Required | Description |
|----------------------|----------|-------------|
| `AWS_ACCESS_KEY_ID` | Yes | Access key ID of your AWS IAM user. |
| `AWS_SECRET_ACCESS_KEY` | Yes | Secret access key of your AWS IAM user. |
| `AWS_BUCKET_NAME` | Yes | Name of the S3 bucket that stores the files. |
| `AWS_BUCKET_REGION` | Yes | AWS region code where the bucket is hosted. Example: `us-east-1` |

### Step 3: Run the container

In a terminal tab, navigate to the directory where you placed the `docker-compose.yml` file and execute the following:

{% tabs %}
{% highlight bash %}
docker compose up
{% endhighlight %}
{% endtabs %}

The File Manager Amazon S3 provider is accessible at http://localhost:5000.

To stop the container, run:

{% tabs %}
{% highlight bash %}
docker compose down
{% endhighlight %}
{% endtabs %}

### Step 4: Configure the client-side File Manager component

Set the `url`, `uploadUrl`, `downloadUrl`, and `getImageUrl` properties in the client-side File Manager component:

| Property | Value |
|----------|-------|
| `url` | `http://localhost:5000/api/AmazonS3Provider/AmazonS3FileOperations` |
| `uploadUrl` | `http://localhost:5000/api/AmazonS3Provider/AmazonS3Upload` |
| `downloadUrl` | `http://localhost:5000/api/AmazonS3Provider/AmazonS3Download` |
| `getImageUrl` | `http://localhost:5000/api/AmazonS3Provider/AmazonS3GetImage` |

The following example shows the File Manager configured with the same AJAX endpoints.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<div class="control-section">
    <div class="sample-container">
        <ejs-filemanager id="filemanager" enableVirtualization="true">
            <e-filemanager-ajaxsettings url="http://localhost:5000/api/AmazonS3Provider/AmazonS3FileOperations"
                                        downloadUrl="http://localhost:5000/api/AmazonS3Provider/AmazonS3Download"
                                        uploadUrl="http://localhost:5000/api/AmazonS3Provider/AmazonS3Upload"
                                        getImageUrl="http://localhost:5000/api/AmazonS3Provider/AmazonS3GetImage">
            </e-filemanager-ajaxsettings>
        </ejs-filemanager>
    </div>
</div>
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
<div class="control-section">
    <div class="sample-container">
        @Html.EJS().FileManager("filemanager").AjaxSettings(
            new Syncfusion.EJ2.FileManager.FileManagerAjaxSettings
            {
                Url = "http://localhost:5000/api/AmazonS3Provider/AmazonS3FileOperations",
                DownloadUrl = "http://localhost:5000/api/AmazonS3Provider/AmazonS3Download",
                UploadUrl = "http://localhost:5000/api/AmazonS3Provider/AmazonS3Upload",
                GetImageUrl = "http://localhost:5000/api/AmazonS3Provider/AmazonS3GetImage"
            }).EnableVirtualization(true).Render()
    </div>
</div>
{% endhighlight %}
{% endtabs %}
{% endif %}

{% if page.publishingplatform == "aspnet-core" %}

For more information on how to get started with the File Manager component, refer to [Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/file-manager/getting-started).

{% elsif page.publishingplatform == "aspnet-mvc" %}

For more information on how to get started with the File Manager component, refer to [Getting Started](https://ej2.syncfusion.com/aspnetmvc/documentation/file-manager/getting-started).

{% endif %}

## Troubleshooting

This section lists common issues and their solutions when deploying the File Manager Amazon S3 provider Docker image.

- The Docker image is built on **ASP.NET Core 10.0**. Ensure that your Docker environment supports the required runtime. If you build a custom image, target `net10.0` or use the same base image to avoid runtime mismatch errors.

- All environment variables listed in the [Amazon S3 credential details](#amazon-s3-credential-details) section are **required**. Missing or incorrect values will cause the provider to fail at startup or return errors during file operations. Verify that `AWS_ACCESS_KEY_ID`, `AWS_SECRET_ACCESS_KEY`, `AWS_BUCKET_NAME`, and `AWS_BUCKET_REGION` are set correctly before running the container.

- If the File Manager client cannot connect to the provider, confirm that the port mapping in `docker-compose.yml` matches the URL configured in the client-side `ajaxSettings`. For example, if the port is mapped as `5000:80`, the client should use `http://localhost:5000` as the host URL.

Please refer to these getting started pages to create a File Manager in [JavaScript](https://ej2.syncfusion.com/javascript/documentation/file-manager/es5-getting-started), [React](https://ej2.syncfusion.com/react/documentation/file-manager/getting-started), [Vue](https://ej2.syncfusion.com/vue/documentation/file-manager/getting-started), [Angular](https://ej2.syncfusion.com/angular/documentation/file-manager/getting-started), [TypeScript](https://ej2.syncfusion.com/documentation/file-manager/getting-started), and [Blazor](https://blazor.syncfusion.com/documentation/file-manager/getting-started-with-web-app).
