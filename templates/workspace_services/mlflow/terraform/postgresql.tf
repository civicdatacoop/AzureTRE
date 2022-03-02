resource "random_string" "username" {
  length    = 10
  upper     = true
  lower     = true
  number    = false
  min_lower = 1
  special   = false
}

resource "random_password" "password" {
  length           = 16
  lower            = true
  min_lower        = 1
  upper            = true
  min_upper        = 1
  number           = true
  min_numeric      = 1
  special          = true
  min_special      = 1
  override_special = "_%@"
}

resource "azurerm_key_vault_secret" "postgresql_admin_password" {
  name         = "${local.postgresql_server_name}-admin-credentials"
  value        = "${random_string.username.result}\n${random_password.password.result}"
  key_vault_id = data.azurerm_key_vault.ws.id
}

resource "azurerm_postgresql_server" "mlflow" {
  name                = local.postgresql_server_name
  location            = data.azurerm_resource_group.ws.location
  resource_group_name = data.azurerm_resource_group.ws.name

  administrator_login          = random_string.username.result
  administrator_login_password = random_password.password.result

  sku_name   = "GP_Gen5_2"
  version    = "11"
  storage_mb = 5120

  backup_retention_days        = 7
  geo_redundant_backup_enabled = false
  auto_grow_enabled            = true

  public_network_access_enabled    = true
  ssl_enforcement_enabled          = true
  ssl_minimal_tls_version_enforced = "TLS1_2"
}

resource "azurerm_postgresql_database" "mlflow" {
  name                = "mlflowdb"
  resource_group_name = data.azurerm_resource_group.ws.name
  server_name         = azurerm_postgresql_server.mlflow.name
  charset             = "UTF8"
  collation           = "English_United States.1252"
}

resource "azurerm_postgresql_virtual_network_rule" "mlflow" {
  name                                 = "mlflow-postgresql-vnet-rule"
  resource_group_name                  = data.azurerm_resource_group.ws.name
  server_name                          = azurerm_postgresql_server.mlflow.name
  subnet_id                            = data.azurerm_subnet.services.id
  ignore_missing_vnet_service_endpoint = false
}