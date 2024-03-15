---
title: {{ model.type }} {{ model.name }}
sidebar_label: {{ model.name }}
---

# Namespace {{ model.name | md.escape }}

{{~ include 'namespace\\item.tpl' 'Classes' 'Class' ~}}   
{{~ include 'namespace\\item.tpl' 'Structs' 'Struct' ~}}
{{~ include 'namespace\\item.tpl' 'Interfaces' 'Interface' ~}}
{{~ include 'namespace\\item.tpl' 'Enums' 'Enum' ~}}
{{~ include 'namespace\\item.tpl' 'Delegates' 'Delegate' ~}}