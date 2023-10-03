#  SDK

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>   
</div>

### Local development

Once you have the SDK setup you may want to iterate on the SDK. Speakeasy supports OpenAPI vendor extensions that can be added to your spec to customize the SDK ergonomics (method names, namespacing resources etc.) and functionality (adding retries, pagination, multiple server support etc)

To get started install the Speakeasy CLI.

In your terminal, run:

```bash
brew install speakeasy-api/homebrew-tap/speakeasy
```
Once you annonate your spec with an extension you will want to run `speakeasy validate` to check the spec for correctness and `speakeasy generate` to recreate the SDK locally. More documentation on OpenAPI extensions [here](https://speakeasyapi.dev/docs/customize-sdks/namespaces/). Here's an example of adding a multiple server support to the spec so that your SDK supports production and sandbox versions of your API. 

```yaml
info:
  title: Example
  version: 0.0.1
servers:
  - url: https://prod.example.com # Used as the default URL by the SDK
    description: Our production environment
    x-speakeasy-server-id: prod
  - url: https://sandbox.example.com
    description: Our sandbox environment
    x-speakeasy-server-id: sandbox
```

Once you're finished iterating and happy with the output push only the latest version of spec into the repo and regenerate the SDK using step 6 above.

<!-- Start SDK Installation -->
## SDK Installation

```bash
pip install git+https://github.com/speakeasy-sdks/template-sdk.git
```
<!-- End SDK Installation -->

## SDK Example Usage
<!-- Start SDK Example Usage -->

```python
import speakeasybar
from speakeasybar.models import operations, shared

s = speakeasybar.Speakeasybar(
    security=shared.Security(
        api_key="",
    ),
)

res = s.drinks.list_drinks(drink_type=shared.DrinkType.WINE)

if res.drinks is not None:
    # handle response
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
## Available Resources and Operations


### [authentication](docs/sdks/authentication/README.md)

* [authenticate](docs/sdks/authentication/README.md#authenticate) - Authenticate with the API by providing a username and password.

### [config](docs/sdks/config/README.md)

* [subscribe_to_webhooks](docs/sdks/config/README.md#subscribe_to_webhooks) - Subscribe to webhooks.

### [drinks](docs/sdks/drinks/README.md)

* [get_drink](docs/sdks/drinks/README.md#get_drink) - Get a drink.
* [list_drinks](docs/sdks/drinks/README.md#list_drinks) - Get a list of drinks.

### [ingredients](docs/sdks/ingredients/README.md)

* [list_ingredients](docs/sdks/ingredients/README.md#list_ingredients) - Get a list of ingredients.

### [orders](docs/sdks/orders/README.md)

* [create_order](docs/sdks/orders/README.md#create_order) - Create an order.
<!-- End SDK Available Operations -->

### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release !

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
